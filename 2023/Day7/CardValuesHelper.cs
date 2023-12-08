namespace AdventOfCode._2023.Day7
{
    public static class CardValueHelper
    {
        public static Dictionary<char, CardValue> GetRegularCardValues()
        {
            return new()
            {
                {'2', CardValue.Two},
                {'3', CardValue.Three},
                {'4', CardValue.Four},
                {'5', CardValue.Five},
                {'6', CardValue.Six},
                {'7', CardValue.Seven},
                {'8', CardValue.Eight},
                {'9', CardValue.Nine},
                {'T', CardValue.Ten},
                {'J', CardValue.Jack},
                {'Q', CardValue.Queen},
                {'K', CardValue.King},
                {'A', CardValue.Ace}
            };
        }

        public static Dictionary<char, CardValue> GetJokerCardValues()
        {
            return new()
            {
                {'2', CardValue.Two},
                {'3', CardValue.Three},
                {'4', CardValue.Four},
                {'5', CardValue.Five},
                {'6', CardValue.Six},
                {'7', CardValue.Seven},
                {'8', CardValue.Eight},
                {'9', CardValue.Nine},
                {'T', CardValue.Ten},
                {'J', CardValue.WeakJack},
                {'Q', CardValue.Queen},
                {'K', CardValue.King},
                {'A', CardValue.Ace}
            };
        }

        public enum CardValue
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            WeakJack = 1,
            Queen = 12,
            King = 13,
            Ace = 14,
        }
    }

}
