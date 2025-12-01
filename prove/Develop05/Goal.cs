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
    private string GetListString()
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
}