using AurieSharpInterop;
using BubbleLib;
using BubbleLib.Core;
using BubbleLib.GUI;
using System;
using System.Reflection;
using YYTKInterop;

namespace SaveGameManager
{
    public class SaveGameManager : BubbleMod
    {
        private string root = Framework.GetGameDirectory();
        private const int SaveSlots = 5;
        private List<MenuItem> saveButtons = [];
        private List<MenuItem> loadButtons = [];

        public SaveGameManager(AurieManagedModule module) : base(module)
        {
        }

        public override string Name => "SaveGameManager";

        public override void Initialize()
        {
            Save(1);

            var mainMenu = Bubble.MainMenu!;

            MenuItem mainMenuItem = new MenuItem(Name, () => { mainMenu.SetPage("SaveGameManager"); });
            mainMenu.AddMenuItem("", mainMenuItem);

            MenuItem loadMenuItem = new MenuItem("Load", () => { mainMenu.SetPage("SaveGameManager_Load"); });
            mainMenu.AddMenuItem("SaveGameManager", loadMenuItem);

            MenuItem saveMenuItem = new MenuItem("Save", () => { mainMenu.SetPage("SaveGameManager_Save"); });
            mainMenu.AddMenuItem("SaveGameManager", saveMenuItem);

            MenuItem backMenuItem = new MenuItem("Back", () => { mainMenu.SetPage(""); }, 999);
            mainMenu.AddMenuItem("SaveGameManager", saveMenuItem);

            MenuItem backMenuItemLoad = new MenuItem("Back", () => { mainMenu.SetPage("SaveGameManager"); }, 999);
            mainMenu.AddMenuItem("SaveGameManager_Load", saveMenuItem);

            MenuItem backMenuItemSave = new MenuItem("Back", () => { mainMenu.SetPage("SaveGameManager"); }, 999);
            mainMenu.AddMenuItem("SaveGameManager_Save", saveMenuItem);

            for (int i = 1; i <= SaveSlots; i++)
            {
                loadButtons.Add(new MenuItem("", () => { Load(i); }));
                saveButtons.Add(new MenuItem("", () => { Save(i); }));
            }

            UpdateButtons();
        }

        private void UpdateButtons()
        {
            for (int i = 1; i <= SaveSlots; i++)
            {
                if (File.Exists($"{root}\\Save_{i}.json"))
                {
                    var saveJson = File.ReadAllText($"{root}\\Save_{i}.json");
                    var saveGame = System.Text.Json.JsonSerializer.Deserialize<SaveGame>(saveJson);
                    loadButtons[i].Text = $"Load [{i}]: {saveGame.Completion} | {DateTime.FromFileTimeUtc(saveGame.TimeStamp).ToString("HH:mm yy/MM/dd")}";
                    saveButtons[i].Text = $"Overwrite [{i}]: {saveGame.Completion} | {DateTime.FromFileTimeUtc(saveGame.TimeStamp).ToString("HH:mm yy/MM/dd")}"; ;
                }
                else
                {
                    loadButtons[i].Text = $"[{i}] --- EMPTY ---";
                    saveButtons[i].Text = $"[{i}] --- EMPTY ---";
                }
                
                
            }
        }

        private void Save(int index)
        {
            var saveDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var saveData = File.ReadAllText($"{saveDir}\\Shelldiver\\save\\Game.json");
            SaveGame newSave = new SaveGame();
            var global = Game.Engine.GetGlobalObject();
            var totalProgress = global["total_skill_levels_upgraded"].ToInt32();
            var allSkillLevels = global["all_skill_levels"].ToInt32();
            newSave.Completion = $"{totalProgress}/{allSkillLevels} Skills";
            newSave.TimeStamp = DateTime.Now.ToFileTimeUtc();
            newSave.Data = saveData;
            var saveJson = System.Text.Json.JsonSerializer.Serialize(newSave);
            File.WriteAllText($"{root}\\Save_{index}.json", saveJson);

            UpdateButtons();
        }

        private void Load(int index)
        {
            if (!File.Exists($"{root}\\Save_{index}.json"))
            {
                return;
            }
            bool overWrite = Game.Engine.CallFunction("show_question", "Are you sure you want to overwrite your current save file?\nThe Game will be closed for the new savefile to take effect.");
            if (overWrite)
            {
                var root = Framework.GetGameDirectory();
                var saveDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var saveJson = File.ReadAllText($"{root}\\Save_{index}.json");
                var saveGame = System.Text.Json.JsonSerializer.Deserialize<SaveGame>(saveJson);
                File.WriteAllText($"{saveDir}\\Shelldiver\\save\\Game.json", saveGame!.Data);
                Game.Engine.CallFunction("game_end");
            }
        }
    }
}
