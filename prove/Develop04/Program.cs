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
                BaseActivity tempActivity = new BaseActivity("Breathing", "This is a breathing exercise.", 20);
                tempActivity.RunActivity();
            }
            else if (response == 2)
            {
                BaseActivity tempActivity = new BaseActivity("Reflection", "This is a reflection exercise.", 20);
                tempActivity.RunActivity();
            }
            else if (response == 3)
            {
                BaseActivity tempActivity = new BaseActivity("Listing", "This is a listing exercise.", 20);
                tempActivity.RunActivity();
            }
        }
        while (response != 4);
    }
}