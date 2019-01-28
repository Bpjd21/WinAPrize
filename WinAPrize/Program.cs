using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGuesses = 3;
            string doorChoice;

            for (int i = 1; i <= totalGuesses; i++)
            {
                Console.WriteLine("Choose a door between 1 and 5 and win that prize! This is attempt " + i + ":");
                doorChoice = Console.ReadLine();

                switch (doorChoice)
                {

                    case "1":
                        Console.WriteLine("You win a Bike!");
                        break;
                    case "2":
                        Console.WriteLine("Uou win a computer!");
                        break;
                    case "3":
                        Console.WriteLine("You win a car!");
                        break;
                    case "4":
                        Console.WriteLine("You win a TV!");
                        break;
                    case "5":
                        Console.WriteLine("You win a Motorcycle!");
                        break;
                    default:
                        Console.WriteLine("You entered an invalid response, you win nothing!");
                        break;
                }
            }
        }
    }
}
