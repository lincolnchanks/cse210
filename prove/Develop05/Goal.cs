using System.Runtime.InteropServices.Marshalling;

abstract class Goal
{
    string _name;
    string _description;
    int _points;
    bool _isDone;

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
            return $"[X] {_name}: {_description} Points: {_points}. Completed: {_isDone}.";
        }
        else
        {
            return $"[ ] {_name}: {_description} Points: {_points}. Completed: {_isDone}.";
        }
    }
    public void DisplayListString()
    {
        Console.WriteLine(this.GetListString());
    }
}