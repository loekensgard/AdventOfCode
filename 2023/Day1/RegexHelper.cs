using System.Text.RegularExpressions;

namespace adventofcode._2023.Day1
{
    public static partial class RegexHelper
    {
        [GeneratedRegex(@"\d")]
        internal static partial Regex FirstDigit();

        [GeneratedRegex(@"\d", RegexOptions.RightToLeft)]
        internal static partial Regex LastDigit();

        [GeneratedRegex(@"\d|one|two|three|four|five|six|seven|eight|nine")]
        internal static partial Regex FirstDigitPartTwo();
        [GeneratedRegex((@"\d|one|two|three|four|five|six|seven|eight|nine"), RegexOptions.RightToLeft)]
        internal static partial Regex LastDigitPartTwo();
    }
}
