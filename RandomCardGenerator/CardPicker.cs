namespace RandomCardGenerator
{
    internal class CardPicker
    {
        public static HashSet<string> RandomCardPicker(int noOfCards)
        {
            HashSet<string> cards = new();
            for(int i = 0; i < noOfCards;)
            {
                if (cards.Add(RandomValue() + " of " + RandomCategory()))
                    i++;
            }
            return cards;
        }

        static Random random = new Random();
        private static string RandomCategory()
        {
            //Random random = new Random();
            int value = random.Next(1,5);
            if (value == 1)
                return "Diamonds";
            if (value == 2)
                return "Clubs";
            if (value == 3)
                return "Spades";
            if (value == 4)
                return "Hearts";
            return "Check the Next method maxValue";
        }

        private static string RandomValue()
        {
            //Random random = new Random();
            int value = random.Next(1, 14);
            if (value == 1)
                return "Ace";
            if (value == 11)
                return "Jack";
            if (value == 12)
                return "Queen";
            if (value == 13)
                return "King";
            return value.ToString();
        }
    }
}
