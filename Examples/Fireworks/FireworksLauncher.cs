using AurieSharpInterop;
using BubbleLib.Core;
using YYTKInterop;

namespace Fireworks
{
    public class FireworksLauncher : InteractableBase
    {
        List<FireworkBubble> bubbles = new List<FireworkBubble>();

        public FireworksLauncher(GameVariable index) : base(index)
        {

        }

        public override Sprite Sprite { get => Sprites.Cannon!; protected set { } }

        protected override void CanInteract(ScriptExecutionContext Context)
        {

        }

        protected override void OnInteract(BuiltinExecutionContext Context)
        {
            for (int i = 0; i < 5; i++)
            {
                FireworkBubble bubble = new FireworkBubble(
                    GML.GetInstanceVariable(Index, "x") + 10,
                    GML.GetInstanceVariable(Index, "y") - 3
                );
                bubbles.Add(bubble);
            }
        }

        public override void PerformEvent(CodeExecutionContext context)
        {
            base.PerformEvent(context);
            if (context.Name.Contains("_Draw_0"))
            {
                foreach (var bubble in bubbles)
                {
                    bubble.Draw();
                }
            }

            if (context.Name.Contains("_Step_0"))
            {
                foreach (var bubble in bubbles.ToList())
                {
                    bubble.Update(1f / 60f);
                    if (bubble.Duration <= 0)
                    {
                        bubbles.Remove(bubble);
                    }
                }
            }


        }
    }
}
