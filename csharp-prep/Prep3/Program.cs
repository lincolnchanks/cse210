using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        int magicNumber;
        int guess;
        // Console.Write("Please enter the magic number: ");
        // magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);

        do
        {
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Higher.");
            }
        } while (guess != magicNumber);
    }
}