class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : 
    base(name, description, points)
    {
        base.SetType("Simple Goal");
    }
    // This class doesn't need to override GetListString() or GetFileString().
    public override void RecordEvent()
    {
        if (!base.GetIsDone())
        {
            base.CompleteGoal();
            base.AwardPoints(base.GetPointsNumber());
        }
    }
}