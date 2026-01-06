using BubbleLib.Core;
using YYTKInterop;

namespace BubbleLib.GUI
{
    public class UI
    {
        internal static void DrawOutlinedText(
            float x,
            float y,
            string text,
            float scaleX,
            float scaleY,
            Color color
        )
        {
            var global = Game.Engine.GetGlobalObject();
            Game.Engine.CallFunction(
                "script_execute",
                global["draw_text_outline"],
                x,
                y,
                text,
                scaleX,
                scaleY,
                color.Value
            );
        }

        internal static int MeasureTextWidth(string text, float scale)
        {
            return (int)(Game.Engine.CallFunction("string_width", text).ToFloat());
        }
    }
}
