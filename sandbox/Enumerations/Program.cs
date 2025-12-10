using static Months;

enum Months {January, February, March, April, May, June, 
    July, August, September, October, November, December}

class Program
{
    public static void Main(string[] args)
    {
        // int DECEMBER = 12;
        int[] DaysInTheMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        Months CurrentMonth = December;

        Console.WriteLine($"The number of days in December is {DaysInTheMonth[(int)December]}");

        Console.WriteLine($"The number of days in December is {DaysInTheMonth[(int)CurrentMonth]}");
    }
}