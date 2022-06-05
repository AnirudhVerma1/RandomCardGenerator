namespace RandomCardGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            if(int.TryParse(input, out int value))
            {
                HashSet<string> cards = CardPicker.RandomCardPicker(value);
                int count = 1;
                foreach(string card in cards)
                {
                    Console.WriteLine(card + " " + count.ToString());
                    count++;
                }
            }
        }
    }
}