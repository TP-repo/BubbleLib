using AurieSharpInterop;
using BubbleLib;
using BubbleLib.Constants;
using BubbleLib.Core;

namespace Fireworks
{
    public class FireworksMod : BubbleMod
    {
        FireworksLauncher launcher;

        public FireworksMod(AurieManagedModule module) : base(module)
        {
        }

        public override string Name => "Fireworks!";

        public override void Initialize()
        {
            Sprites.Load();
            var instance = GML.AddObjectToRoom(Rooms.Main_island, "par_interactable", 2600, 379);
            launcher = new FireworksLauncher(instance);
            Bubble.RegisterInstance(launcher);
        }



    }
}
