using AurieSharpInterop;
using BubbleLib.Constants;
using BubbleLib.Core;
using BubbleLib.GUI;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;
using YYTKInterop;

namespace BubbleLib
{
    public static class Bubble
    {
        public const string Version = "0.0.2";
        
        private static readonly Dictionary<int, InstanceBase> Instances = [];
        private static bool IsInitialized = false;
        private static readonly List<BubbleMod> Mods = [];

        public static string CurrentRoom { get; private set; } = "rm_logo";
        public static AurieManagedModule? Module { get; private set; }
        public static Menu? MainMenu { get; private set; }
        public static Menu? PauseMenu { get; private set; }

        public static void RegisterInstance(InstanceBase instance)
        {
            int id = instance.Id;
            if (!Instances.ContainsKey(id))
            {
                Instances.Add(id, instance);
            }
        }

        internal static void SetModule(AurieManagedModule module)
        {
            Module = module;
        }

        /// <summary>
        /// Registers all event-hooks and loads static resources (sprites etc.) 
        /// </summary>
        /// <param name="module"></param>
        private static void Initialize()
        {
            Game.Engine.CallFunction("show_debug_overlay", Config.Instance.EnableDebugOverlay);
            Game.Events.AddPostScriptNotification(Module, "gml_Script_get_version_text", AppendLibToVersionString);
            Game.Events.AddPostBuiltinNotification(Module, "room_goto", OnRoomChanged);

            CreateMenus();
            Framework.Print($"BubbleLib v{Version} loaded");
            LoadMods();
        }

        private static void LoadMods()
        {
            if (!Directory.Exists("mods\\bubble"))
            {
                Directory.CreateDirectory("mods\\bubble");
            }
            var modFiles = Directory.GetFiles($"mods\\bubble", "*.dll");
            for (int i = 0; i < modFiles.Length; i++)
            {
                string? file = modFiles[i];
                try
                {
                    Framework.Print($"Loading mod from file: {file}");
                    AssemblyLoadContext loadContext = AssemblyLoadContext.GetLoadContext(Assembly.GetAssembly(typeof(Bubble))!)!;
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        var assembly = loadContext!.LoadFromStream(fs);
                        var modType = assembly.GetTypes().FirstOrDefault(t => t.BaseType?.FullName == typeof(BubbleMod).FullName);
                        if (modType != null)
                        {
                            var mod = (BubbleMod?)modType.GetConstructor([typeof(AurieManagedModule)])?.Invoke([Module]);
                            if (mod != null)
                            {
                                Mods.Add(mod);
                                Framework.Print($"Added mod: {mod.Name}");
                            }
                            else
                            {
                                Framework.PrintEx(AurieLogSeverity.Warning, $"Could not create mod instance from type \"{modType.FullName}\" in file \"{file}\"");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Framework.PrintEx(AurieLogSeverity.Error, $"Error while loading mod from file \"{file}\": {ex}");
                }
            }
            foreach (BubbleMod mod in Mods)
            {
                Framework.Print($"Initializing mod: {mod.Name}");
                mod.Initialize();
            }
        }

        private static void CreateMenus()
        {
            var global = Game.Engine.GetGlobalObject();
            var pages = global["main_menu"]["pages"];
            var pause_pages = global["pause_menu"]["pages"];
            MainMenu = new Menu(global["menu_pos"], 110, 148, () => { return CurrentRoom == Rooms.Main_menu && pages.ToArrayView().Last() == 1; });
            PauseMenu = new Menu(global["menu_pos"], 110, 148, () =>
            {
                return global["pause"];
            });

            MenuItem modsMenu = new MenuItem("Mods", () => { MainMenu.SetPage("Mods"); });
            MainMenu.AddMenuItem("", modsMenu);

            //TODO: Register Mod Pages automatically?

            MenuItem bubbleLib = new MenuItem("BubbleLib", () => { MainMenu.SetPage("BubbleLib"); });
            MainMenu.AddMenuItem("Mods", bubbleLib);

            MenuItem DebugMode = new MenuItem(Config.Instance.EnableDebugOverlay ? "Disable Debug Overlay" : "Enable Debug Overlay");
            DebugMode.Action = () =>
            {
                Config.Instance.EnableDebugOverlay = !Config.Instance.EnableDebugOverlay;
                Config.Save();
                Game.Engine.CallFunction("show_debug_overlay", Config.Instance.EnableDebugOverlay);
                DebugMode.Text = Config.Instance.EnableDebugOverlay ? "Disable Debug Overlay" : "Enable Debug Overlay";
            };
            MainMenu.AddMenuItem("BubbleLib", DebugMode);


            //TODO: Add back buttons automatically
            MenuItem bubbleBack = new MenuItem("Back", () => { MainMenu.SetPage("Mods"); }, 999);
            MainMenu.AddMenuItem("BubbleLib", bubbleBack);

            MenuItem modsBack = new MenuItem("Back", () => { MainMenu.SetPage(""); }, 999);
            MainMenu.AddMenuItem("Mods", modsBack);
        }

        /// <summary>
        /// Builtin function hook to keep track of current room (bound to room_goto)
        /// </summary>
        private static void OnRoomChanged(BuiltinExecutionContext Context)
        {
            CurrentRoom = Game.Engine.CallFunction("room_get_name", Context.Arguments[0]);
        }

        /// <summary>
        /// Handles all game events and passes relevant events through to modded instances
        /// </summary>
        internal static void OnGameEvent(CodeExecutionContext context)
        {
            if (!InputController.IsInitialized && context.Self.Name == "struct o_input")
            {
                InputController.Initialize(context.Self);
            }

            // Draw GUI elements
            if (context.Name.Contains("o_input_Draw"))
            {
                Mouse.Update();
                MainMenu?.Draw();
                PauseMenu?.Draw();
                foreach (BubbleMod mod in Mods)
                {
                    mod.DrawGUI();
                }
            }

            if (context.Self.IsInstance())
            {
                GameInstance instance = GameInstance.FromObject(context.Self);
                if (instance != null)
                {
                    //Perform events for modded instances
                    int id = instance.ID;
                    if (Instances.TryGetValue(id, out InstanceBase? value))
                    {
                        value.PerformEvent(context);
                    }
                }
            }
        }

        internal static void OnFrame(int FrameNumber, double DeltaTime)
        {
            // Initialize on first frame to prevent thread issues
            if (!IsInitialized)
            {
                IsInitialized = true;
                Initialize();
            }
            MainMenu?.Update((float)DeltaTime);
            PauseMenu?.Update((float)DeltaTime);

            foreach (BubbleMod mod in Mods)
            {
                mod.Update(DeltaTime);
            }
        }

        private static void AppendLibToVersionString(ScriptExecutionContext Context)
        {
            var result = Context.GetResult();
            Context.OverrideResult(new GameVariable($"{result} - BubbleLib v{Version}"));
        }


    }
}
