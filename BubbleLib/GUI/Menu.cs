using BubbleLib.Constants;
using BubbleLib.Core;
using YYTKInterop;

namespace BubbleLib.GUI
{
    public class Menu
    {
        private const int index_offset = 100;
        private const int index_total = index_offset * 2;

        private readonly Dictionary<string, List<MenuItem>> allMenuItems = [];
        private List<MenuItem> currentMenuItems = [];
        private string menuPage = "";
        private readonly GameVariable MenuPos;
        private readonly Func<bool> IsActive;

        private int ySize = 0;

        private readonly int XOffset;
        private readonly int YOffset;

        private int YPos
        {
            get { return MenuPos["ypos"]; }
            set { MenuPos["ypos"] = value; }
        }

        public Menu(GameVariable menuPos, int xOffset, int yOffset, Func<bool> isActive)
        {
            InputController.OnPress += HandleInput;
            var global = Game.Engine.GetGlobalObject();
            XOffset = xOffset;
            YOffset = yOffset;
            MenuPos = menuPos;
            IsActive = isActive;
            SetPage(menuPage);
        }

        public void SetPage(string page)
        {
            menuPage = page;
            YPos = index_offset;
            if (allMenuItems.TryGetValue(page, out List<MenuItem>? value))
            {
                currentMenuItems = value;
            }
            else
            {
                allMenuItems.Add(page, []);
                currentMenuItems = allMenuItems[page];
            }
            foreach (var item in currentMenuItems)
            {
                item.Selected = false;
            }
        }

        public void AddMenuItem(string page, MenuItem item)
        {
            if (!allMenuItems.TryGetValue(page, out List<MenuItem>? value))
            {
                value = [];
                allMenuItems.Add(page, value);
            }

            value.Add(item);
            value.Sort((a, b) => a.Order.CompareTo(b.Order));
        }

        public void Update(float dt)
        {
            if (!IsActive())
            {
                return;
            }
            if (MenuPos["ysize"] < index_total)
            {
                ySize = MenuPos["ysize"];
                MenuPos["ysize"] += index_total;
            }
            if (currentMenuItems != null)
            {
                for (int i = 0; i < currentMenuItems.Count; i++)
                {
                    MenuItem? item = currentMenuItems[i];
                    bool hovered = item.IsInside(Mouse.X, Mouse.Y, XOffset, YOffset + 16 * i);
                    if (hovered)
                    {
                        YPos = i + index_offset;
                    }
                    bool selected = YPos == i + index_offset;
                    if (selected && !item.Selected)
                    {
                        Game.Engine.CallFunction("audio_play_sound", GML.GetAsset("snd_select"), 10, false);
                    }
                    item.Selected = selected;

                    item.Update(dt);
                }
            }
        }

        public void Draw()
        {
            if (!IsActive() || currentMenuItems == null)
            {
                return;
            }

            for (int i = 0; i < currentMenuItems.Count; i++)
            {
                MenuItem? item = currentMenuItems[i];

                item.Draw(XOffset, YOffset + 16 * i);
            }
        }

        private void HandleInput(string input)
        {
            if (!IsActive())
            {
                return;
            }
            UpdateMenuPos();
            switch (input)
            {
                case Inputs.UpMenu:
                    if (YPos == index_offset - 1)
                    {
                        YPos = index_offset;
                    }
                    break;
                case Inputs.DownMenu:
                    if (YPos > ySize && YPos < index_offset)
                    {
                        YPos = ySize;
                    }
                    if (YPos > index_offset + currentMenuItems.Count - 1)
                    {
                        YPos = index_offset + currentMenuItems.Count - 1;
                    }
                    break;
                case Inputs.RightMenu:
                    if (currentMenuItems.Count > 0 && YPos > 0 && YPos <= currentMenuItems.Count)
                    {
                        YPos += index_offset - 1;
                    }
                    break;
                case Inputs.LeftMenu:
                    if (YPos >= index_offset)
                    {
                        YPos -= index_offset - 1;
                    }
                    break;
                case Inputs.Enter:
                    var selectedItem = currentMenuItems.FirstOrDefault(i => i.Selected);
                    selectedItem?.Action?.Invoke();
                    break;
            }
        }

        private void UpdateMenuPos()
        {
            YPos = MenuPos["ypos"];
        }
    }
}
