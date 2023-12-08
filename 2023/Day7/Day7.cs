namespace AdventOfCode._2023.Day7
{
    public static class Day7
    {
        public static string SolvePartOne(string[] lines)
        {
            List<Hand> hands = [];

            foreach (var line in lines)
            {
                var handSplit = line.Split(' ');
                var cards = handSplit[0];
                var bid = int.Parse(handSplit[1]);
                var type = CardSolver.GetCardType(handSplit[0]);
                hands.Add(new Hand(cards, bid, type));
            }

            var cardValues = CardValueHelper.GetRegularCardValues();

            var orderedHands = hands.OrderBy(hand => hand.Type)
                .ThenBy(hand => cardValues[hand.Cards[0]])
                .ThenBy(hand => cardValues[hand.Cards[1]])
                .ThenBy(hand => cardValues[hand.Cards[2]])
                .ThenBy(hand => cardValues[hand.Cards[3]])
                .ThenBy(hand => cardValues[hand.Cards[4]]);

            return orderedHands.Select((hand, index) => hand.Bid * (index + 1)).Sum().ToString();
        }


        public static string SolvePartTwo(string[] lines)
        {
            var cardValues = CardValueHelper.GetJokerCardValues();

            List<Hand> hands = [];
            foreach (var line in lines)
            {
                var handSplit = line.Split(' ');
                var cards = handSplit[0];
                var bid = int.Parse(handSplit[1]);
                var type = CardSolver.GetCardTypeWeak(handSplit[0]);
                hands.Add(new Hand(cards, bid, type));
            }

            var orderedHands = hands.OrderBy(hand => hand.Type)
               .ThenBy(hand => cardValues[hand.Cards[0]])
               .ThenBy(hand => cardValues[hand.Cards[1]])
               .ThenBy(hand => cardValues[hand.Cards[2]])
               .ThenBy(hand => cardValues[hand.Cards[3]])
               .ThenBy(hand => cardValues[hand.Cards[4]]);

            return orderedHands.Select((hand, index) => hand.Bid * (index + 1)).Sum().ToString();
        }
    }
}
