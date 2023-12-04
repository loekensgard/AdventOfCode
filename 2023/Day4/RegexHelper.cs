using System.Text.RegularExpressions;

namespace AdventOfCode._2023.Day4
{
    public static partial class RegexHelper
    {
        [GeneratedRegex(@"Card\s+(\d+):\s+((?:\d+\s*)+)\|\s+((?:\d+\s*)+)")]
        public static partial Regex GetCardValues();
    }
}
