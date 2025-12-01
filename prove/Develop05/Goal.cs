using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isDone;
    private string _type;

    public Goal(string name, string description, int numPoints)
    {
        _name = name;
        _description = description;
        _points = numPoints;
        _isDone = false;
    }
    protected virtual string GetListString() // This one can only be called by child classes.
    {
        if (_isDone)
        {
            return $"[X] {_name}: {_description}. Type: {_type}. Points: {_points}. Completed: {_isDone}.";
        }
        else
        {
            return $"[ ] {_name}: {_description}. Type: {_type}. Points: {_points}. Completed: {_isDone}.";
        }
    }
    public void DisplayListString()
    {
        Console.WriteLine(this.GetListString());
    }
    protected virtual string GetFileString()
    {
        return $"{_type}#{_name}#{_description}#{_points}#{_isDone}";
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