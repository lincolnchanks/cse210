using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("Red", 10);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("Blue", 10, 4);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
    }
}