using AurieSharpInterop;
using BubbleLib;

namespace SaveGameManager
{
    static class Main
    {
        public static AurieStatus InitializeMod(AurieManagedModule Module)
        {
            Bubble.RegisterMod(new SaveGameManager(Module));

            return AurieStatus.Success;
        }

        public static void UnloadMod(AurieManagedModule Module)
        {
        }
    }
}
