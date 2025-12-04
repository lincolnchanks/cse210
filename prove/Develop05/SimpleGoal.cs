class SimpleGoal : Goal
{
    public SimpleGoal(string type) : 
    base(type)
    {
        
    }
    public SimpleGoal(string type, string name, string description, int points, bool isDone) : 
    base(type, name, description, points, isDone)
    {
        
    }
    // This class doesn't need to override GetListString() or GetFileString(),
    // it has no new information to add to those methods.
    public override void RecordEvent(Goals goals)
    {
        if (!base.GetIsDone())
        {
            base.CompleteGoal();
            base.AwardPoints(base.GetPointsNumber(), goals);
        }
    }
}