using System.Text.RegularExpressions;

namespace AdventOfCode._2023.Day4
{
    public static partial class CardHelper
    {
        public static Card ParseCard(string input, Regex regex)
        {
            var match = regex.Match(input);

            var id = int.Parse(match.Groups[1].Value);
            var winningNumbers = match.Groups[2].Value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var myNumbers = match.Groups[3].Value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            return new Card
            {
                Id = id,
                WinningNumbers = winningNumbers,
                MyNumbers = myNumbers
            };
        }
    }
}
