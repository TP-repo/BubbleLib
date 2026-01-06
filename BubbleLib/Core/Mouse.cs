using YYTKInterop;

namespace BubbleLib.Core
{
    public class Mouse
    {
        public delegate void ClickHandler(int button, int x, int y);
        public static event ClickHandler? OnClick;

        private static int x;
        private static int y;
        public static int X
        {
            get { return x; }
        }

        public static int Y
        {
            get { return y; }
        }

        internal static void Update()
        {
            var global = Game.Engine.GetGlobalObject();
            x = Game.Engine.GetBuiltinVariable("mouse_x", global, 0) - global["cam_x"];
            y = Game.Engine.GetBuiltinVariable("mouse_y", global, 0) - global["cam_y"];
            bool left_clicked = Game.Engine.CallFunction("mouse_check_button_pressed", 1);
            if (left_clicked)
            {
                OnClick?.Invoke(0, X, Y);
            }
            bool right_clicked = Game.Engine.CallFunction("mouse_check_button_pressed", 2);
            if (right_clicked)
            {
                OnClick?.Invoke(1, X, Y);
            }
        }
    }
}
