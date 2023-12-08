
namespace AdventOfCode._2023.Day5
{
    public static class Day5
    {
        public static string SolvePartOne(string[] lines)
        {
            var seeds = SoilHelper.GetSeeds(lines[0]);
            var maps = SoilHelper.GetMaps(lines);

            return SoilHelper.FindLowestSeed(seeds, maps).ToString();
        }

        public static string SolvePartTwo(string[] arg)
        {
            return 0.ToString();
        }
    }
}
