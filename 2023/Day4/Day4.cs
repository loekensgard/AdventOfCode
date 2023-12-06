namespace AdventOfCode._2023.Day4
{
    public static class Day4
    {
        public static string SolvePartOne(string[] lines)
        {
            var cards = lines.Select(line => CardHelper.ParseCard(line, RegexHelper.GetCardValues())).ToList();
            return cards.Select(x => x.Score).Sum().ToString();
        }

        public static string SolvePartTwo(string[] lines)
        {
            var cards = lines.Select(line => CardHelper.ParseCard(line, RegexHelper.GetCardValues())).ToList();

            var partTwo = cards.Select(_ => 1).ToArray();

            int i = 0;
            foreach (var card in cards)
            {
                var count = partTwo[i];
                for (var j = 0; j < card.Matches; j++)
                {
                    partTwo[i + j + 1] += count;
                }
                i++;
            }

            return partTwo.Sum().ToString();
        }

    }
}
