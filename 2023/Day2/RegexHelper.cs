using System.Text.RegularExpressions;

namespace adventofcode._2023.Day2;

public static partial class RegexHelper
{
    [GeneratedRegex(@"\d+\s(red|green|blue)")]
    internal static partial Regex CubePattern();

}
