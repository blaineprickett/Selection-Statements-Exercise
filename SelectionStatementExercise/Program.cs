using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite number?");

            int favoriteNumber = 7;
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                string input = Console.ReadLine();
                int userGuess = int.Parse(input);

                if (userGuess > favoriteNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (userGuess < favoriteNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("You got it!");
                    guessedCorrectly = true;
                }
            }
        }
    }
}
