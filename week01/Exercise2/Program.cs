using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letterGrade = "";

        string gradeSign = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if ((grade % 10 >= 7 && (letterGrade == "A" || letterGrade == "F")) || (grade % 10 <= 3 && (letterGrade == "A" || letterGrade == "F")))
        {
            gradeSign = "";
        }
        else if (grade % 10 >= 7)
        {
            gradeSign = "+";
        }
        else if (grade % 10 <= 3)
        {
            gradeSign = "-";
        }
        Console.WriteLine(letterGrade + gradeSign);

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class but you can try again next semester.");
        }
    }
}