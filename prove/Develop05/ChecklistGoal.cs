class ChecklistGoal : Goal
{
    private int _numTimesCompleted;
    private int _maxTimes;
    private int _bonusPoints;

    public ChecklistGoal(string type)
    : base(type)
    {
        _numTimesCompleted = 0;
        _maxTimes = ObtainMaxTimes();
        _bonusPoints = ObtainBonusPoints();
    }
    public int ObtainMaxTimes()
    {
        int maxTimesNum = 0;
        while (maxTimesNum <= 0)
        {
            Console.WriteLine("What is the maximum number of times this goal can be completed?");
            try
            {
                maxTimesNum = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input must be an integer value greater than 0.");
            }
        }
        return maxTimesNum;
    }
    public int ObtainBonusPoints()
    {
        int bonusPointsNum = 0;
        while (bonusPointsNum <= 0)
        {
            Console.WriteLine("How many bonus points will be awarded for completing the entire goal?");
            try
            {
                bonusPointsNum = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input must be an integer value greater than 0.");
            }
        }
        return bonusPointsNum;
    }
    protected override string GetListString()
    {
        return $"{base.GetListString()}. Completed: {_numTimesCompleted}/{_maxTimes}. Bonus Points: {_bonusPoints}.";
    }
    protected override string GetFileString()
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