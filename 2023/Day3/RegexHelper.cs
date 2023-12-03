using System.Text.RegularExpressions;

namespace AdventOfCode._2023.Day3
{
    public static partial class RegexHelper
    {
        [GeneratedRegex(@"[^.0-9]")]
        public static partial Regex GetSymbols();
        [GeneratedRegex(@"\d+")]
        public static partial Regex GetNumbers();
        [GeneratedRegex(@"\*")]
        public static partial Regex GetGears();
    }
}
