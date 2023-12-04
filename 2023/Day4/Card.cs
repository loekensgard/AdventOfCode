namespace AdventOfCode._2023.Day4
{
    public class Card
    {
        public int Id { get; set; }
        public List<int> WinningNumbers { get; set; } = [];
        public List<int> MyNumbers { get; set; } = [];

        public int Score
        {
            get
            {
                int score = 0;
                foreach (var number in MyNumbers)
                {
                    if (WinningNumbers.Contains(number))
                    {
                        score = (score == 0) ? 1 : score * 2;
                    }
                }
                return score;
            }
        }

        public int Matches
        {
            get
            {
                return MyNumbers.Count(WinningNumbers.Contains);
            }
        }
    }
}
