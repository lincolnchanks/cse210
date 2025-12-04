class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private string _filename;
    private int _totalScore;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.DisplayListString();
        }
    }
    public void DisplayChooseGoalMenu()
    {
        int count = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetListString()}");
            count++;
        }
    }
}