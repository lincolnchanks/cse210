using static Months;

enum Months {January, February, March, April, May, June, 
    July, August, September, October, November, December}
// You can use this in the food program to help with indexes and indexing!
// enum InputLoadData {}
class Program
{
    public static void Main(string[] args)
    {
        // int DECEMBER = 12;
        int[] DaysInTheMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        Months CurrentMonth = December;

        Console.WriteLine($"The number of days in December is {DaysInTheMonth[(int)December]}");

        Console.WriteLine($"The number of days in December is {DaysInTheMonth[(int)CurrentMonth]}");

        Console.WriteLine($"The number of days in November is {DaysInTheMonth[(int)November]}");
        Console.WriteLine($"The number of days in August is {DaysInTheMonth[(int)August]}");

        Console.WriteLine($"The number of days in February is {DaysInTheMonth[(int)February]}");
        Console.WriteLine($"The number of days in June is {DaysInTheMonth[(int)June]}");
        Console.WriteLine($"The number of days in January is {DaysInTheMonth[(int)January]}");
        Console.WriteLine($"The number of days in May is {DaysInTheMonth[(int)May]}");
    }
}