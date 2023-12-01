namespace adventofcode._2023.Day1
{
    public static class PuzzleHelper
    {
        public static int SolvePartOne(string[] lines)
        {
            int partOne = 0;
            var matchStart = RegexHelper.FirstDigit();
            var matchEnd = RegexHelper.LastDigit();

            foreach (var line in lines)
            {
                var first = matchStart.Match(line).Value;
                var last = matchEnd.Match(line).Value;

                partOne += int.Parse(first + last);
            }

            return partOne;
        }

        public static int SolvePartTwo(string[] lines)
        {
            int partTwo = 0;
            var matchStart2 = RegexHelper.FirstDigitPartTwo();
            var matchEnd2 = RegexHelper.LastDigitPartTwo();

            foreach (var line2 in lines)
            {
                var first = DigitHelper.ReturnNumberAsString(matchStart2.Match(line2).Value);
                var last = DigitHelper.ReturnNumberAsString(matchEnd2.Match(line2).Value);

                partTwo += int.Parse(first + last);
            }

            return partTwo;
        }
    }
}
