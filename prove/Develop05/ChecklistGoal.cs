class ChecklistGoal : Goal
{
    private int _numTimesCompleted;
    private int _maxTimes;
    private int _bonusPoints;

    public ChecklistGoal(string type, int maxTimes, int bonusPoints)
    : base(type)
    {
        // base.SetType("Checklist Goal");
        _numTimesCompleted = 0;
        _maxTimes = maxTimes;
        _bonusPoints = bonusPoints;
    }
    protected override string GetListString()
    {
        return $"{base.GetListString()}. Completed: {_numTimesCompleted}/{_maxTimes}. Bonus Points: {_bonusPoints}.";
    }
    public override string GetFileString()
    {
        return $"{base.GetFileString()}#{_numTimesCompleted}#{_maxTimes}#{_bonusPoints}";
    }
    public override void RecordEvent()
    {
        if (!base.GetIsDone())
        {
            _numTimesCompleted++;
            base.AwardPoints(base.GetPointsNumber());
            if (_numTimesCompleted == _maxTimes)
            {
                base.AwardPoints(_bonusPoints);
                base.CompleteGoal();
            }
        }
    }
}