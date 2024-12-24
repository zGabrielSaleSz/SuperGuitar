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

        internal static void MinLength(string anyString, int minLength)
        {
            if (anyString.Length < minLength)
            {
                throw new Exception($"{anyString} must have at least {minLength} lenghts");
            }
        }

        internal static void IsInteger(string value, out int integer)
        {
            if(!int.TryParse(value, out integer))
            {
                throw new Exception($"Value {value} int not an integer");
            }
        }

        internal static void NotNull<T>(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
        }
    }
}
