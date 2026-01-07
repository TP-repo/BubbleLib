using AurieSharpInterop;
using YYTKInterop;

namespace BubbleLib
{
    internal static class Main
    {
        /// <summary>
        /// The mod entrypoint. Called once when the mod is being loaded.
        /// </summary>
        /// <param name="module">
        /// A unique opaque structure describing the loaded mod.
        /// </param>
        /// <returns>
        /// A status value representing if the method succeeded or not.<br/>
        /// If a mod fails loading, it is promptly unloaded.
        /// </returns>
        public static AurieStatus InitializeMod(AurieManagedModule module)
        {
            Bubble.SetModule(module);
            Game.Events.OnFrame += Bubble.OnFrame;
            Game.Events.OnGameEvent += Bubble.OnGameEvent;
            return AurieStatus.Success;
        }

        /// <summary>
        /// The mod unload routine. Called when a mod is unloaded or hot-reloaded.
        /// </summary>
        /// <param name="Module">
        /// A unique opaque structure describing the loaded mod.
        /// Is the same as the one passed to InitializeMod.
        /// </param>
        public static void UnloadMod(AurieManagedModule Module)
        {
            // Clean up resources and hooks here for hot reloading
            Framework.Print($"BubbleLib unloaded");
        }
    }
}
