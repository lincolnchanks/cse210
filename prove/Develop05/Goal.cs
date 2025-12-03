using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isDone;
    private string _type;

    public Goal(string type)
    {
        _name = ObtainGoalName();
        _description = ObtainGoalDescription();
        _points = ObtainNumberOfPoints();
        _isDone = false;
        _type = type;
    }
    protected virtual string GetListString() // This one can only be called by child classes.
    {
        return $"Name: {_name}, Description: {_description}, Points: {_points}, Status: {_isDone}";
    }
    public void DisplayListString()
    {
        Console.WriteLine(this.GetListString());
    }
    public virtual string GetFileString() // make protected later
    {
        return $"{_type}#{_name}#{_description}#{_points}#{_isDone}";
    }
    public string ObtainGoalName()
    {
        Console.WriteLine("Enter the name of this goal:");
        string goalName = Console.ReadLine();
        return goalName;
    }
    public string ObtainGoalDescription()
    {
        Console.WriteLine("Enter a short description of this goal:");
        string goalDescription = Console.ReadLine();
        return goalDescription;
    }
    public int ObtainNumberOfPoints()
    {
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
    public abstract void RecordEvent();
    public void AwardPoints(int numPoints)
    {
        // No code here yet. Waiting for the User class.
    }
    public virtual string[] ReadGoalInformation(string fileString)
    {
        // Not fully functional at the time.
        string[] goalInfo = fileString.Split("#");
        return goalInfo;
    }
    protected void SetType(string type)
    {
        _type = type;
    }
    protected void CompleteGoal()
    {
        if (_type != "Eternal Goal")
        {
            _isDone = true;
        }
        else
        {
            Console.WriteLine("Cannot complete an Eternal Goal!");
        }
    }
    protected int GetPointsNumber()
    {
        return _points;
    }
    protected bool GetIsDone()
    {
        return _isDone;
    }
}