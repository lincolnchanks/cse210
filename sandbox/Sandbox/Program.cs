using System;

class Program
{ // void means: don't return anything. That's this function's return type. // Must have Main, must be capitalized.
    static void Main(string[] args) 
    {
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is: {lastName}, {firstName}.");
    }
}