using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity currentActivity = new BaseActivity("Breathing", "This is a breathing exercise.", 20);

        int response = 0;
        do
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            response = int.Parse(Console.ReadLine());
        }
        while (response != 4);
    }
}