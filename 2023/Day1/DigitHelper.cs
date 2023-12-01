namespace adventofcode._2023.Day1
{
    public static class DigitHelper
    {
        public static string ReturnNumberAsString(string input)
        {
            var isNumber = int.TryParse(input, out var _);
            return isNumber ? input : GetDigitFromWord(input);
        }

        private static string GetDigitFromWord(string input) => input switch
        {
            "one" => "1",
            "two" => "2",
            "three" => "3",
            "four" => "4",
            "five" => "5",
            "six" => "6",
            "seven" => "7",
            "eight" => "8",
            "nine" => "9",
            _ => throw new ArgumentOutOfRangeException(nameof(input))
        };
    }
}
