using System.Text.RegularExpressions;

namespace AdventOfCode._2023.Day3
{
    public static class SchematicsHelpers
    {
        public static bool IsNeighbours(Gear partOne, Gear partTwo)
        {
            return Math.Abs(partTwo.Row - partOne.Row) <= 1 &&
                partOne.Col <= partTwo.Col + partTwo.Number.Length &&
                partTwo.Col <= partOne.Col + partOne.Number.Length;
        }

        public static Gear[] Parse(string[] rows, Regex rx)
        {
            List<Gear> partsList = [];
            for (int row = 0; row < rows.Length; row++)
            {
                foreach (Match match in rx.Matches(rows[row]))
                {
                    partsList.Add(new Gear(match.Value, row, match.Index));
                }
            }
            Gear[] result = [.. partsList];
            return result;
        }
    }
}
