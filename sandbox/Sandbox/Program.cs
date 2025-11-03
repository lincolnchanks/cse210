using System;

class Program
{ // void means: don't return anything. That's this function's return type. // Must have Main, must be capitalized.
    static void Main(string[] args) //static: you don't need an object to call this function.
    {
        Console.WriteLine("Hello Sandbox World!"); //Console.WriteLine() doesn't leave the cursor on the written line.
        string firstName; // C# is a strongly-typed language, meaning every variable must have a type and it must be used. It also must be declared before it is used.
        string lastName;
        //Console.Read() only returns one character as an int.
        Console.Write("Please enter your first name: "); //Console.Write() leaves the cursor on the written line.
        firstName = Console.ReadLine();

        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine(); //ReadLine(): Title Case. lastName: Camel Case. last_name: Snake Case.

        Console.WriteLine($"Your name is: {lastName}, {firstName}.");

        // Comments: double slash
        /*
        Multi-line comment (aka docstring?)
        */

        // ; Use semicolons at the end of statements
        // Begs the question: what's a statement?

        // Variables and Datatypes: int, string, float, double, bool

        // Formatted strings: Console.WriteLine($"The name is: {name}.")

        // int.Parse() number.ToString()

        // If statements, ||, &&, !

        // int x = 10;
        // // Don't put semicolons after if statements or loops. 
        // if (!(x == 10 || x == 12 && x == 13 && x != 23))// You don't need brackets if the if statement is only one line of code.
        // {
        //     Console.WriteLine("X is 10.");
        // }
        // else if (x == 435)
        // {
        //     Console.WriteLine("Hey Bob."); // C#: All strings must be in double quotes. Single quotes are only for single characters.
        // }
        // else
        // {
        //     Console.WriteLine("Goodbye Bob."); 
        // }
        // Loops, For, while, do while, foreach

        // Console.WriteLine(Math.Pow(2, 10));

        // int x = 10;
        // Console.WriteLine($"{x}, {++x}, {x++}, {x}");
        // //++x increments x then uses the value of x.
        // //x++ uses the value of x before you increment it.

        // // Loops

        // for (int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"The value of i is: {i}");
        // }

        // for (int i = 0; i <= 1000; i += 10)
        // {
        //     Console.WriteLine($"The value of i is {i}.");
        // }

        // for (int i = -10000; i <= 10000; i += 100)
        // {
        //     Console.WriteLine($"The value of i is: {i}.");
        // }

        // for (int i = -10000; i >= -100000; i -= 100)
        // {
        //     Console.WriteLine($"The value of i is: {i}.");
        // }

        // for (double i = 1.234; i < 12.234234; i += .234)
        // {
        //     Console.WriteLine($"The value of i is: {i}.");
        // }

        bool done = false;
        // While loops need entrance strategy (how to get in) and exit strategy (how to get out)
        while (!done)
        {
            Console.Write("Input your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 125)
            {
                done = true;
                Console.WriteLine($"Super age: {age}.");
            }
        }
    }
}