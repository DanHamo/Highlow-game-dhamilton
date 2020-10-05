using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to highlow, guess a number between 1 and 10");

            // Picks random number
            Random rng = new Random();
            int number = rng.Next(1, 11);
            int NoOfGuess = 0;

            // Create while loop
            while (true)
            {

                // Enter user guess
                Console.Write("Enter guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                NoOfGuess = NoOfGuess + 1;

                // Compare guess to number
                if (guess < number)
                {
                    Console.WriteLine("Too low go higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high go lower");
                }
                else
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine("It took you " + NoOfGuess.ToString());
                    break;
                }
            }

            //Waits for keypress
            Console.ReadKey();
        }
    }
}
