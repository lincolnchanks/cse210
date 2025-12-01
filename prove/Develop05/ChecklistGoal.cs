class ChecklistGoal : Goal
{
    private int _numTimesCompleted;
    private int _maxTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int maxTimes, int bonusPoints)
    : base(name, description, points)
    {
        base.SetType("Checklist Goal");
        _numTimesCompleted = 0;
        _maxTimes = maxTimes;
        _bonusPoints = bonusPoints;
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Method is not implemented yet!");
    }
    protected override string GetListString()
    {
        return $"{base.GetListString()}. Completed: {_numTimesCompleted}/{_maxTimes}. Bonus Points: {_bonusPoints}.";
    }
}