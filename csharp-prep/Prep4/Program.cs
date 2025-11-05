using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int newNum;
        do
        {
            Console.Write("Enter a number: ");
            newNum = int.Parse(Console.ReadLine());
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        } while (newNum != 0);

        int sum = 0;
        double average;
        int maximum = 0;

        foreach (int n in numbers)
        {
            sum += n;
            if (n > maximum)
            {
                maximum = n;
            }
        }
        average = (double)sum / (double)numbers.Count;

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {maximum}.");

        // foreach (int n in numbers)
        // {
        //     Console.WriteLine($"{n}");
        // }
    }
}