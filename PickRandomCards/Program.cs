using System.Security.Cryptography.X509Certificates;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter the numbers of cards you want to pick: ");

            string line = Console.ReadLine();

            Console.WriteLine();    // tom linje for penere utskrift

            if (int.TryParse(line, out int numberOfCards)) 
            {
                // this block is executed if line COULD be converted to an int
                // value stored in variable numberOfCards
                foreach (string card in CardPicker.PickSomeCards(numberOfCards)) 
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();    // tom linje for penere utskrift
            }
            else 
            {
                // this block is executed if line COULD NOT be converted to an int
                Console.WriteLine("\nPlease enter a valid card number.\n\n");
            }
        }
    }
}
