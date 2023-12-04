namespace AdventOfCode._2023.Day4
{
    public class Card
    {
        public int Id { get; set; }
        public List<int> WinningNumbers { get; set; }
        public List<int> MyNumbers { get; set; }

        private int _score;
        public int Score
        {
            get
            {
                _score = 0;
                foreach (var number in MyNumbers)
                {
                    if (WinningNumbers.Contains(number))
                    {
                        if(_score == 0)
                        {
                            _score = 1;
                        }
                        else
                        {
                            _score *= 2;
                        }
                    }
                }
                return _score;
            }
        }

        private int _matches;

        public int Matches
        {
            get
            {
                _matches = 0;
                foreach (var number in MyNumbers)
                {
                    if(WinningNumbers.Contains(number)) 
                    {
                        _matches++;
                    }
                }
                return _matches;
            }
        }
    }
}
