namespace RandomCardGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to generate(1 to 52): ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                if ((value < 53) && (value > 0))
                {
                    HashSet<string> cards = CardPicker.RandomCardPicker(value);
                    int count = 1;
                    foreach (string card in cards)
                    {
                        Console.WriteLine("Card Number " + count.ToString() + " : " + card);
                        count++;
                    }
                }
                else
                    Console.WriteLine("Enter the number between 1 to 52 only.");
            }
            else
                Console.WriteLine("Enter a valid number.");
        }
    }
}