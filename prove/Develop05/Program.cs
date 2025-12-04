using System;
using System.ComponentModel;
using System.Diagnostics;

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
        Goals goalsList = new Goals();

        Menu menu = new Menu();
        int response = 0;

        while (response != 6)
        {
            Console.Clear();
            response = menu.DisplayMenu();

            switch (response)
            {
                case 1:
                // Create a new goal of the type specified by the user.
                // Add that goal to the overall goals list.
                    Console.Clear();
                    int goalType = menu.DisplayCreateGoalMenu();
                    switch (goalType)
                    {
                        case 1:
                            SimpleGoal tempSimpleGoal = new SimpleGoal("Simple");
                            goalsList.AddGoal(tempSimpleGoal);
                            break;
                        case 2:
                            EternalGoal tempEternalGoal = new EternalGoal("Eternal");
                            goalsList.AddGoal(tempEternalGoal);
                            break;
                        case 3:
                            ChecklistGoal tempChecklistGoal = new ChecklistGoal("Checklist");
                            goalsList.AddGoal(tempChecklistGoal);
                            break;
                    }
                    break;
                case 2:
                // Display each goal in the overall goals list.
                    Console.Clear();
                    goalsList.DisplayTotalPoints();
                    goalsList.DisplayGoals();
                    Console.WriteLine("Press ENTER to continue.");
                    string uselessString = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Saving Goals...");
                    // Gets a file name from the user, then writes to that file.
                    Console.WriteLine("Enter the filename to save to:");
                    string filename = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach(Goal goal in goalsList.GetGoalsList())
                        {
                            outputFile.WriteLine($"{goal.GetFileString()}");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Loading Goals...");
                    break;
                case 5:
                    Console.Clear();
                    int goalNumber = goalsList.DisplayChooseGoalMenu();
                    goalsList.GetGoalsList()[goalNumber - 1].RecordEvent(goalsList);
                    break;
            }
        }
    }
}