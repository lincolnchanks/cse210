using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6/7);

        Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");
        fraction2.SetBottom(4);
        Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");
    }
}