using YYTKInterop;

namespace BubbleLib
{
    public static class Extensions
    {
        // TODO: Do conversion for all "ref" types
        public static int GetInstanceId(this GameVariable variable)
        {
            if (variable.Type != "ref")
            {
                return -1;
            }
            if (variable.ToString().StartsWith("ref instance "))
            {
                var str = variable.ToString().Replace("ref instance ", "");
                if (int.TryParse(str, out int id))
                {
                    return id;
                }
            }
            return -1;
        }
    }
}
