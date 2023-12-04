using System.Diagnostics.Metrics;

namespace AdventOfCode._2023.Day4
{
    public static class Day4
    {
        public static int SolvePartOne(string[] lines)
        {
            var cards = new List<Card>();

            foreach (var line in lines)
            {
                var cardRegex = RegexHelper.GetCardValues();
                cards.Add(CardHelper.ParseCard(line, cardRegex));
            }

            return cards.Select(x => x.Score).Sum();
        }

        public static int SolvePartTwo(string[] lines)
        {
            var cards = new List<Card>();

            foreach (var line in lines)
            {
                var cardRegex = RegexHelper.GetCardValues();
                cards.Add(CardHelper.ParseCard(line, cardRegex));
            }

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

            return partTwo.Sum();
        }

    }
}
