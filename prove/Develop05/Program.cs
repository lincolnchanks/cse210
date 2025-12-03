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
            response = menu.DisplayMenu();

            switch (response)
            {
                case 1:
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
                            ChecklistGoal tempChecklistGoal = new ChecklistGoal("Checklist", 100);
                            goalsList.AddGoal(tempChecklistGoal);
                            break;
                    }
                    break;
                case 2:
                    goalsList.DisplayGoals();
                    break;
                case 3:
                    Console.WriteLine("Saving Goals...");
                    break;
                case 4:
                    Console.WriteLine("Loading Goals...");
                    break;
                case 5:
                    Console.WriteLine("Recording Event...");
                    break;
            }
        }
    }
}