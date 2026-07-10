using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcomeMessage();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResult(name, square);


        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name} The square of your number is {square}.");
        }
    }
}