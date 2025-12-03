class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private string _filename;
    private int _totalScore;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}