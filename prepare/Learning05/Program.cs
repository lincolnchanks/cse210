using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("Red", 10);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
    }
}