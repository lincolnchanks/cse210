using System;

class Program
{
    static void Main(string[] args)
    {
        List<Fraction> fractions = new List<Fraction>();

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        fractions.Add(fraction1);
        fractions.Add(fraction2);
        fractions.Add(fraction3);
        fractions.Add(fraction4);

        foreach(Fraction fraction in fractions)
        {
            Console.WriteLine(fraction.GetFractionString());
            Console.WriteLine(fraction.GetDecimalValue());
        }

        // Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");
        // fraction2.SetBottom(4);
        // Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");
    }
}