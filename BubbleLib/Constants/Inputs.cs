namespace BubbleLib.Constants
{
    /// <summary>
    /// Input strings used in game events
    /// </summary>
    public static class Inputs
    {
        public const string Attack = "attack";
        public const string Back = "back";
        public const string CardDown = "card_down";
        public const string CardLeft = "card_left";
        public const string CardRight = "card_right";
        public const string CardUp = "card_up";
        public const string Crouch = "crouch";
        public const string DirMovePressed = "dir_move_pressed";
        public const string DirMoveReleased = "dir_move_released";
        public const string Down = "down";
        public const string DownMenu = "down_menu";
        public const string DownMenuPressed = "down_menu_pressed";
        public const string Enter = "enter";
        public const string EnterPressed = "enter_pressed";
        public const string EnterReleased = "enter_released";
        public const string HideUi = "hide_ui";
        public const string InputId = "input_id";
        public const string Inspect = "inspect";
        public const string Interact = "interact";
        public const string InteractHold = "interact_hold";
        public const string InvisibleFrames = "invisible_frames";
        public const string IsMovingAny = "is_moving_any";
        public const string IsMovingHorizontal = "is_moving_horizontal";
        public const string IsSwappingInputs = "is_swapping_inputs";
        public const string JlDown = "jl_down";
        public const string JlDownPressed = "jl_down_pressed";
        public const string JlHorizontal = "jl_horizontal";
        public const string JlLeft = "jl_left";
        public const string JlLeftPressed = "jl_left_pressed";
        public const string JlRight = "jl_right";
        public const string JlRightPressed = "jl_right_pressed";
        public const string JlUp = "jl_up";
        public const string JlUpPressed = "jl_up_pressed";
        public const string JlVertical = "jl_vertical";
        public const string JrDown = "jr_down";
        public const string JrDownPressed = "jr_down_pressed";
        public const string JrHorizontal = "jr_horizontal";
        public const string JrLeft = "jr_left";
        public const string JrLeftPressed = "jr_left_pressed";
        public const string JrRight = "jr_right";
        public const string JrRightPressed = "jr_right_pressed";
        public const string JrUp = "jr_up";
        public const string JrUpPressed = "jr_up_pressed";
        public const string JrVertical = "jr_vertical";
        public const string Jump = "jump";
        public const string Left = "left";
        public const string LeftMenu = "left_menu";
        public const string LeftMenuPressed = "left_menu_pressed";
        public const string Mouse = "mouse";
        public const string MousePressed = "mouse_pressed";
        public const string MouseReleased = "mouse_released";
        public const string MouseRight = "mouse_right";
        public const string MoveUi = "move_ui";
        public const string OpenInventory = "open_inventory";
        public const string OpenSkilltree = "open_skilltree";
        public const string Pause = "pause";
        public const string ReloadTool = "reload_tool";
        public const string Restart = "restart";
        public const string Right = "right";
        public const string RightMenu = "right_menu";
        public const string RightMenuPressed = "right_menu_pressed";
        public const string ScrollDown = "scroll_down";
        public const string ScrollDownPressed = "scroll_down_pressed";
        public const string ScrollUp = "scroll_up";
        public const string ScrollUpPressed = "scroll_up_pressed";
        public const string Start = "start";
        public const string Stats = "stats";
        public const string UiBack = "ui_back";
        public const string Unpause = "unpause";
        public const string Up = "up";
        public const string UpMenu = "up_menu";
        public const string UpMenuPressed = "up_menu_pressed";
        public const string UseBubbleGun = "use_bubble_gun";
        public const string UsePlasmaGun = "use_plasma_gun";
        public const string ZoomIn = "zoom_in";
        public const string ZoomOut = "zoom_out";

        internal static string[] FloatInputs =
        {
            "back",
            "input_id",
            "interact",
            "mouse",
            "mouse_right",
            "open_inventory",
            "open_skilltree",
            "pause",
            "reload_tool",
            "scroll_down",
            "scroll_up",
            "use_bubble_gun",
            "use_plasma_gun",
            "zoom_in",
            "zoom_out",
        };

        internal static string[] BoolInputs =
        {
            "attack",
            "crouch",
            "card_up",
            "up",
            "up_menu",
            "card_left",
            "left",
            "left_menu",
            "card_down",
            "down",
            "down_menu",
            "card_right",
            "right",
            "right_menu",
            "enter",
            "hide_ui",
            "inspect",
            "jl_down",
            "jl_down_pressed",
            "jl_horizontal",
            "jl_left",
            "jl_right",
            "jl_up",
            "jl_vertical",
            "jr_down",
            "jr_horizontal",
            "jr_left",
            "jr_right",
            "jr_up",
            "jr_vertical",
            "jump",
            "move_ui",
            "restart",
            "start",
            "stats",
            "ui_back",
            "unpause",
        };
    }
}
