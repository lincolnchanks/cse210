using System;

class Program
{
    static string GetInputString(string inputMessage)
    {
        Console.WriteLine(inputMessage);
        Console.Write("> ");
        string returnString = Console.ReadLine();
        return returnString;
    }
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int response = 0;

        while (response != 6)
        {
            response = menu.DisplayMenu();
        }
    }
}

// string goalType = GetInputString("What type of goal are you creating? (simple, eternal, checklist)");
                    // string goalName = GetInputString("Enter the name of the goal.");
                    // string goalDescription = GetInputString("Enter a short description of the goal.");
                    // int goalPoints = int.Parse(GetInputString("Enter the number of points for completion."));
                    // if (goalType.ToLower() == "simple")
                    // {
                    //     SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    // }
                    // else if (goalType.ToLower() == "checklist")
                    // {
                    //     int goalMaxTimes = int.Parse(GetInputString("Enter the max number of times to complete this goal."));
                    //     int goalBonusPoints = int.Parse(GetInputString("Enter the bonus points for completing all of the goals."));
                    // }