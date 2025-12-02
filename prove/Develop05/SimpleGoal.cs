class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string type) : 
    base(name, description, type)
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