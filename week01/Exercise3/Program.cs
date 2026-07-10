using System;

class Program
{
    static void Main(string[] args)
    {

        string playAgain;

        do
        {
            Random random = new();
            int numberToGuess = random.Next(1, 101);
            int numberOfTries = 0;
            bool hasGuessedCorrectly = false;

            while (!hasGuessedCorrectly)
            {
                Console.Write("What is your guess? ");
                int playerGuess = int.Parse(Console.ReadLine());
                numberOfTries++;

                if (playerGuess < numberToGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (playerGuess > numberToGuess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    hasGuessedCorrectly = true;
                    Console.WriteLine($"Congratulations! You guessed it in {numberOfTries} tries.");
                }
            }

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        while (playAgain == "Yes" || playAgain == "yes" || playAgain == "Y" || playAgain == "y");

        // The following code is redundant and should be removed.
    }
}