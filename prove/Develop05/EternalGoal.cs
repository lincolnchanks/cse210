class EternalGoal : Goal
{
    private int _numTimesDone;

    public EternalGoal(string type) : 
    base(type)
    {
        _numTimesDone = 0;
    }
    protected override string GetListString() // This has to also be protected.
    {
        return $"{base.GetListString()}. Number of completions: {_numTimesDone}.";
    }
    protected override string GetFileString()
    {
        return $"{base.GetFileString()}#{_numTimesDone}";
    }
    public override void RecordEvent()
    {
        base.AwardPoints(base.GetPointsNumber());
    }
}