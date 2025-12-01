class EternalGoal : Goal
{
    private int _numTimesDone;

    public EternalGoal(string name, string description, int points) : 
    base(name, description, points)
    {
        _numTimesDone = 0;
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Not implemented yet!");
    }
}