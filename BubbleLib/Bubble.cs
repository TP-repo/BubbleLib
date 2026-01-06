using AurieSharpInterop;
using BubbleLib.Constants;
using BubbleLib.Core;
using BubbleLib.GUI;
using YYTKInterop;

namespace BubbleLib
{
    public static class Bubble
    {
        public const string Version = "0.0.1";
        private static AurieManagedModule? Module;
        private static readonly Dictionary<string, InstanceBase> Instances = [];
        private static bool IsInitialized = false;
        private static readonly List<BubbleMod> Mods = [];

        public static string CurrentRoom { get; private set; } = "rm_logo";

        public static Menu? MainMenu { get; private set; }
        public static Menu? PauseMenu { get; private set; }

        /// <summary>
        /// Gets and hooks the globally valid script-index from a bound method.
        /// </summary>
        /// <param name="method">REF to method-index</param>
        /// <param name="handler">The handler that should be called</param>
        public static void HookMethod(GameVariable method, AfterScriptCallbackHandler handler)
        {
            try
            {
                var method_index = Game.Engine.CallFunction("method_get_index", method);
                Game.Events.AddPostScriptNotification(Module, method_index.ToString().Replace("ref script ", "gml_Script_"), handler);
            }
            catch (Exception ex)
            {
                Framework.PrintEx(AurieLogSeverity.Error, $"Error while hooking \"{method}\": {ex}");
            }
        }

        public static void RegisterMod(BubbleMod mod)
        {
            Mods.Add(mod);
            if (IsInitialized)
            {
                mod.Initialize();
                mod.IsInitialized = true;
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

            foreach (BubbleMod mod in Mods)
            {
                if (!mod.IsInitialized)
                {
                    mod.Initialize();
                    mod.IsInitialized = true;
                }
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
                    string id = instance.ID.ToString();
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
