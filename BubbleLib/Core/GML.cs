using AurieSharpInterop;
using YYTKInterop;

namespace BubbleLib.Core
{
    public class GML
    {
        public static GameVariable? GetInstanceVariable(GameVariable instance, string name)
        {
            try
            {
                return Game.Engine.CallFunction("variable_instance_get", instance, name);
            }
            catch (Exception ex)
            {
                Framework.PrintEx(AurieLogSeverity.Error, $"Error while fetching \"{name}\": {ex}");
                return null;
            }
        }

        public static void SetInstanceVariable(
            GameVariable instance,
            string name,
            GameVariable value
        )
        {
            try
            {
                Game.Engine.CallFunction("variable_instance_set", instance, name, value);
            }
            catch (Exception ex)
            {
                Framework.PrintEx(AurieLogSeverity.Error, $"Error while fetching \"{name}\": {ex}");
            }
        }

        public static bool HasInstanceVariable(GameVariable instance, string name)
        {
            try
            {
                return Game.Engine.CallFunction("variable_instance_exists", instance, name);
            }
            catch (Exception ex)
            {
                Framework.PrintEx(AurieLogSeverity.Error, $"Error while fetching \"{name}\": {ex}");
            }
            return false;
        }

        /// <summary>
        /// Adds a new instance to a room based on an object template.
        /// </summary>
        /// <param name="roomName">Use constants from <see cref="Constants.Rooms"/></param>
        /// <param name="objectName">Name of the object template</param>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        /// <returns>REF Index of the new instance</returns>
        public static GameVariable AddObjectToRoom(string roomName, string objectName, int x, int y)
        {
            var objectRef = Game.Engine.CallFunction("asset_get_index", objectName);
            var roomRef = Game.Engine.CallFunction("asset_get_index", roomName);
            var instance = Game.Engine.CallFunction("room_instance_add", roomRef, x, y, objectRef);

            return instance;
        }

        public static GameVariable? GetAsset(string assetName)
        {
            var assetIndex = Game.Engine.CallFunction("asset_get_index", assetName);
            return assetIndex;
        }

        internal static bool InstanceExists(GameVariable index)
        {
            return Game.Engine.CallFunction("instance_exists", index);
        }
    }
}
