using SuperGuitar.Core.Notes;

namespace SuperGuitar.Core.Tools
{
    public static class Ensure
    {
        internal static void MaxValue(int maxValue, int value)
        {
            if (value > maxValue)
            {
                throw new Exception($"{value} can't be greater than max value {maxValue}");
            }
        }

        internal static void NotNull<T>(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
        }
    }
}
