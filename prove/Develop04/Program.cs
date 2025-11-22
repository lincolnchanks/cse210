using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity currentActivity = new BaseActivity("Breathing", "This is a breathing exercise.", 20);
        Dictionary<int, string> activities = new Dictionary<int, string>();

        activities.Add(1, "Breathing");
        activities.Add(2, "Reflection");
        activities.Add(3, "Listing");

        int response;
        do
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                Console.WriteLine("Breathing");
            }
            else if (response == 2)
            {
                Console.WriteLine("Reflection");
            }
            else if (response == 3)
            {
                Console.WriteLine("Listing");
            }
        }
        while (response != 4);
    }
}