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
                    // Gets a file name from the user, then writes to that file.
                    Console.WriteLine("Enter the filename to save to:");
                    string outputFileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(outputFileName))
                    {
                        foreach(Goal goal in goalsList.GetGoalsList())
                        {
                            outputFile.WriteLine($"{goal.GetFileString()}");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Loading Goals...");
                    Console.WriteLine("Enter the filename to load from:");
                    string inputFileName = Console.ReadLine();
                    string[] strings = System.IO.File.ReadAllLines(inputFileName);

                    goalsList = new Goals();

                    foreach (string line in strings)
                    {
                        string[] parts = line.Split("#");

                        string tempFileGoalType = parts[0];
                        string tempFileGoalName = parts[1];
                        string tempFileGoalDesc = parts[2];
                        int tempFileGoalPoints = int.Parse(parts[3]);
                        string tempFileGoalStatus = parts[4];

                        bool tempFileGoalBool;
                        if (tempFileGoalStatus == "True")
                        {
                            tempFileGoalBool = true;
                        }
                        else
                        {
                            tempFileGoalBool = false;
                        }

                        switch (tempFileGoalType)
                        {
                            case "Simple":
                                SimpleGoal tempFileSimpleGoal = new SimpleGoal(tempFileGoalType, tempFileGoalName, tempFileGoalDesc, tempFileGoalPoints, tempFileGoalBool);
                                goalsList.AddGoal(tempFileSimpleGoal);
                                break;
                            case "Eternal":
                                EternalGoal tempFileEternalGoal = new EternalGoal(tempFileGoalType, tempFileGoalName, tempFileGoalDesc, tempFileGoalPoints, tempFileGoalBool);
                                goalsList.AddGoal(tempFileEternalGoal);
                                break;
                            case "Checklist":
                                int tempFileGoalNumCompletions = int.Parse(parts[5]);
                                int tempFileGoalMaxTimes = int.Parse(parts[6]);
                                int tempFileGoalBonusPoints = int.Parse(parts[7]);
                                ChecklistGoal tempFileChecklistGoal = new ChecklistGoal(tempFileGoalType, tempFileGoalName, tempFileGoalDesc, tempFileGoalPoints, tempFileGoalBool, tempFileGoalNumCompletions, tempFileGoalMaxTimes, tempFileGoalBonusPoints);
                                goalsList.AddGoal(tempFileChecklistGoal);
                                break;
                        }
                    }
                    string uselessSecond = Console.ReadLine();
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