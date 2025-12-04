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
    public int DisplayChooseGoalMenu()
    {
        int count = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetListString()}");
            count++;
        }
        count -= 1; // This reverts the count back to the actual length of the list.
        int goalNum = 0;
        while (goalNum < 1 || goalNum > count)
        {
            Console.WriteLine("Which goal would you like to complete?");
            try
            {
                goalNum = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"Input must be an integer value between 1 and {count - 1}.");
            }
        }
        return goalNum;
    }
    public void AwardPoints(int numPoints)
    {
        _totalScore += numPoints;
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }
    public void DisplayTotalPoints()
    {
        Console.WriteLine($"Total Points: {_totalScore}.");
    }
}