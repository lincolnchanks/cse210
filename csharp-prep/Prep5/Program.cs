using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int squareNumber(int num)
    {
        return (int)Math.Pow(num, 2);
    }
    static void DisplayResult(string userName, int squaredNumber, int userBirthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        
        int ageThisYear = 2025 - userBirthYear;
        Console.WriteLine($"{userName}, you will turn {ageThisYear} this year.");
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber, birthYear);
    }
}