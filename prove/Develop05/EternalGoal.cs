class EternalGoal : Goal
{
    private int _numTimesDone;

    public EternalGoal(string name, string description, int points) : 
    base(name, description, points)
    {
        _numTimesDone = 0;
        base.SetType("Eternal Goal");
    }
    protected override string GetListString() // This has to also be protected.
    {
        return $"{base.GetListString}. Number of completions: {_numTimesDone}.";
    }
    protected override string GetFileString()
    {
        return $"{base.GetFileString()}#{_numTimesDone}";
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Not implemented yet!");
    }
}