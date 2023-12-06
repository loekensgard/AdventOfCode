namespace AdventOfCode._2023.Day3;

partial class Day3
{
    public static string SolvePartOne(string[] lines)
    {
        var symbols = SchematicsHelpers.Parse(lines, RegexHelper.GetSymbols());
        var numbers = SchematicsHelpers.Parse(lines, RegexHelper.GetNumbers());

        int sum = 0;
        foreach (var number in numbers)
        {
            if (symbols.Any(symbol => SchematicsHelpers.IsNeighbours(symbol, number)))
            {
                sum += int.Parse(number.Number);
            }
        }
        return sum.ToString();
    }

    public static string SolvePartTwo(string[] lines)
    {
        var gears = SchematicsHelpers.Parse(lines, RegexHelper.GetGears());
        var numbers = SchematicsHelpers.Parse(lines, RegexHelper.GetNumbers());

        int sum = 0;
        foreach (var gear in gears)
        {
            var neighbours = new List<int>();
            foreach (var number in numbers)
            {
                if (SchematicsHelpers.IsNeighbours(number, gear))
                {
                    neighbours.Add(int.Parse(number.Number));
                }
            }

            if (neighbours.Count == 2)
            {
                sum += neighbours.First() * neighbours.Last();
            }
        }
        return sum.ToString();
    }
}

