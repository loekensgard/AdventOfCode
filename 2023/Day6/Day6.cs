namespace AdventOfCode._2023.Day6
{
    public static class Day6
    {
        public static string SolvePartOne(string[] lines)
        {
            var regex = RegexHelper.GetNumbers();
            var times = regex.Matches(lines[0]).Select(x => long.Parse(x.Value)).ToArray();
            var distances = regex.Matches(lines[1]).Select(x => long.Parse(x.Value)).ToArray();

            long winningTimes = 1;

            for (var i = 0; i < times.Length; i++)
            {
                var totalTime = times[i];
                var totalDistance = distances[i];

                winningTimes *= CalculatorHelper.CalculateWinningTimes(totalTime, totalDistance);
            }

            return winningTimes.ToString();
        }

        public static string SolvePartTwo(string[] lines)
        {
            var regex = RegexHelper.GetNumbers();
            var times = regex.Matches(lines[0].Replace(" ", string.Empty)).Select(x => long.Parse(x.Value)).ToArray();
            var distances = regex.Matches(lines[1].Replace(" ", string.Empty)).Select(x => long.Parse(x.Value)).ToArray();

            long winningTimes = 1;

            for (var i = 0; i < times.Length; i++)
            {
                var totalTime = times[i];
                var totalDistance = distances[i];

                winningTimes *= CalculatorHelper.CalculateWinningTimes(totalTime, totalDistance);
            }

            return winningTimes.ToString();
        }
    }
}
