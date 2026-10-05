using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;

            int min = 1;
            int max = 100;

            int number,guess,attempts;
            string input;
            string response;

            while (playAgain)
            {
                number = random.Next(min, max + 1);
                guess = 0;
                attempts = 0;

                Console.WriteLine("Guess a number between " + min + " and " + max + ":");

                while (guess != number)
                {
                    Console.Write("Enter your guess: ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out guess) == false)
                    {
                        Console.WriteLine("Please enter a valid number!");
                        continue;
                    }

                    attempts++;

                    if (guess > number)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Too low!");
                    }
                }

                Console.WriteLine("Correct! You guessed it in " + attempts + " attempts.");

                Console.Write("Do you want to play again? (y/n): ");
                response = Console.ReadLine();

                if (response == "y" || response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}