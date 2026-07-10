using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int sum = 0;
        int count = 0;
        int number;

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
                count++;
            }
        }
        while (number != 0);

        Console.WriteLine($"The sum is: {sum}");

        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        int smallestPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();
    }
}