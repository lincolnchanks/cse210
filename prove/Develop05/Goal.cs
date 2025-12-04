using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isDone;
    private string _type;
    private int _pointsAwarded;
    // This value will be updated by RecordEvent() and AwardPoints(). Then
    // when RecordEvent() is called on it in the Goals class, the Goals class
    // will get this value and add it to the overall points value.

    public Goal(string type)
    {
        _name = ObtainGoalName();
        _description = ObtainGoalDescription();
        _points = ObtainNumberOfPoints();
        _isDone = false;
        _type = type;
    }
    public Goal(string type, string name, string description, int points, bool isDone)
    {
        _name = name;
        _description = description;
        _points = points;
        _isDone = isDone;
        _type = type;
    }
    public virtual string GetListString() // This one can only be called by child classes.
    {
        // Get a string to display in Action 2.
        return $"Type: {_type}, Name: {_name}, Description: {_description}, Points: {_points}, Status: {_isDone}";
    }
    public void DisplayListString()
    {
        // Display a string from the above method.
        Console.WriteLine(this.GetListString());
    }
    public virtual string GetFileString()
    {
        // Get a string to display in the file.
        return $"{_type}#{_name}#{_description}#{_points}#{_isDone}";
    }
    public string ObtainGoalName()
    {
        // Get user input for the goal name. Constructor function.
        Console.WriteLine("Enter the name of this goal:");
        string goalName = Console.ReadLine();
        return goalName;
    }
    public string ObtainGoalDescription()
    {
        // Get user input for the goal description. Constructor function.
        Console.WriteLine("Enter a short description of this goal:");
        string goalDescription = Console.ReadLine();
        return goalDescription;
    }
    // public int ObtainIntValue(ref int intValue)
    // {
    //     while (intValue <= 0)
    //     {
    //         Console.WriteLine("How many points is this goal worth?");
    //         try
    //         {
    //             intValue = int.Parse(Console.ReadLine());
    //         }
    //         catch (Exception ex)
    //         {
    //             Console.WriteLine("Input must be an integer value greater than 0.");
    //         }
    //     }
    //     return intValue;
    // }
    public int ObtainNumberOfPoints()
    {
        // Get user input for the goal point value. Constructor function.
        int inputPointsNum = 0;
        while (inputPointsNum <= 0)
        {
            Console.WriteLine("How many points is this goal worth?");
            try
            {
                inputPointsNum = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input must be an integer value greater than 0.");
            }
        }
        return inputPointsNum;
    }
    public abstract void RecordEvent(Goals goals); // Goal completion; overriden by derived classes
    public void AwardPoints(int numPoints, Goals goals)
    {
        goals.AwardPoints(numPoints);
        Console.WriteLine($"Awarded {numPoints} points!");
    }
    public virtual string[] ReadGoalInformation(string fileString)
    {
        // Not fully functional at the time.
        string[] goalInfo = fileString.Split("#");
        return goalInfo;
    }
    protected void CompleteGoal()
    {
        // Mark the goal as complete unless it's eternal.
        if (_type != "Eternal")
        {
            _isDone = true;
        }
        else
        {
            Console.WriteLine("Cannot complete an Eternal Goal!");
        }
    }
    public int GetPointsNumber()
    {
        // Return number of points.
        return _points;
    }
    protected bool GetIsDone()
    {
        // Return the goal status.
        return _isDone;
    }
    public string GetGoalType()
    {
        return _type;
    }
}