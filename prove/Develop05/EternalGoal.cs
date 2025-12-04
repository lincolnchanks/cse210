class EternalGoal : Goal
{
    private int _numTimesDone;

    public EternalGoal(string type) : 
    base(type)
    {
        _numTimesDone = 0;
    }
    public EternalGoal(string type, string name, string description, int points, bool isDone) : 
    base(type, name, description, points, isDone)
    {
        _numTimesDone = 0; // This needs to get changed!!!
    }
    public override string GetListString() // This has to also be protected.
    {
        return $"{base.GetListString()}. Number of completions: {_numTimesDone}.";
    }
    public override string GetFileString()
    {
        return $"{base.GetFileString()}#{_numTimesDone}";
    }
    public override void RecordEvent(Goals goals)
    {
        base.AwardPoints(base.GetPointsNumber(), goals);
    }
}