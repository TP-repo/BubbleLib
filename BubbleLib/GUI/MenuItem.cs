using BubbleLib.Core;

namespace BubbleLib.GUI
{
    public class MenuItem
    {
        private string? text;

        /// <summary>
        /// Duration of select animation in seconds
        /// </summary>
        private readonly float animationDuration = 1f;

        private float animationTimer = 0f;

        /// <summary>
        /// x-offset/indent when text is selected
        /// </summary>
        private const int selectedOffset = 4;

        public string Text
        {
            get
            {
                return text!;
            }
            set
            {
                text = value;
                Width = UI.MeasureTextWidth(text, 1f) + selectedOffset + Sprite.ChangeArrow.Width;
            }
        }
        public bool Selected { get; set; } = false;
        public int Width { get; private set; }
        public int Height { get; private set; }

        /// <summary>
        /// The action performed when this menu item is clicked/activated
        /// </summary>
        public Action? Action;

        public int Order { get; set; }

        public MenuItem(string text, Action? action = null, int order = 0)
        {
            Text = text;
            Height = 16;
            Action = action;
            Order = order;
        }

        public void Draw(int xOffset = 0, int yOffset = 0)
        {
            UI.DrawOutlinedText(
                xOffset + float.Lerp(0, selectedOffset, animationTimer),
                yOffset,
                Text,
                1f,
                1f,
                Selected ? Color.White : Color.Silver
            );
            if (Selected)
            {
                Sprite.SelectedArrow.Draw(
                    xOffset + Width - 8 + float.Lerp(0, selectedOffset, animationTimer),
                    yOffset + Height / 2
                );
            }
        }

        public void Update(float dt)
        {
            if (Selected && animationTimer < 1f)
            {
                animationTimer += dt / animationDuration;
                if (animationTimer > 1f)
                    animationTimer = 1f;
            }
            else if (!Selected && animationTimer > 0f)
            {
                animationTimer -= dt / animationDuration;
                if (animationTimer < 0f)
                    animationTimer = 0f;
            }
        }

        public bool IsInside(int x, int y, int xOffset = 0, int yOffset = 0)
        {
            return x > xOffset && y > yOffset && x < Width + xOffset && y < Height + yOffset;
        }
    }
}
