using static AdventOfCode._2023.Day7.CardType;

namespace AdventOfCode._2023.Day7
{
    public static class CardSolver
    {
        public static CardType GetCardType(string cards)
        {
            var cardNumberType = cards.GroupBy(c => c)
                                         .Select(g => g.Count())
                                         .ToList();

            return cardNumberType.Count switch
            {
                1 => FiveOfAKind,
                2 => cardNumberType.Contains(4) ? FourOfAKind : FullHouse,
                3 => cardNumberType.Contains(3) ? ThreeOfAKind : TwoPair,
                4 => OnePair,
                _ => HighCard,
            };
        }

        public static CardType GetCardTypeWeak(string cards)
        {
            if (cards.Equals("JJJJJ"))
            {
                return FiveOfAKind;
            }

            var cardMap = cards.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            if (cardMap.TryGetValue('J', out var jokers))
            {
                cardMap.Remove('J');

                var maxCard = cardMap.OrderByDescending(kv => kv.Value).First();
                cardMap[maxCard.Key] += jokers;
            }

            var cardNumberType = cardMap.Values.ToList();

            return cardNumberType.Count switch
            {
                1 => FiveOfAKind,
                2 when cardNumberType.Contains(4) => FourOfAKind,
                2 => FullHouse,
                3 when cardNumberType.Contains(3) => ThreeOfAKind,
                3 => TwoPair,
                4 => OnePair,
                _ => HighCard,
            };
        }
    }
}
