class SimpleGoal : Goal
{
    public SimpleGoal(string type) : 
    base(type)
    {
        
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