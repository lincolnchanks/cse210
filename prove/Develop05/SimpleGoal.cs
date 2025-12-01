class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : 
    base(name, description, points)
    {
        base.SetType("Simple Goal");
    }
    // public override string GetListString()
    // {
    // }
    public override void RecordEvent()
    {
        Console.WriteLine("Event not recorded! Method is not yet functional.");
    }
}