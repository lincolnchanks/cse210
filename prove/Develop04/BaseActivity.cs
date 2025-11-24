class BaseActivity
{
    private string _name = "";
    private string _description = "";
    private int _duration;
    // private string _startMessage = "Welcome to the Mindfulness activity!";
    // private string _endMessage = "End message";

    public BaseActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    protected string GetDescription()
    {
        return _description;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void RunActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        DisplayAnimation(10);
        DisplayCountdown(10);
    }

    public void DisplayAnimation(int seconds)
    {
        string animationString = "\\|/-";
        int sleepTime = 250;
        int index = 0;
        DateTime endTime = GetEndTime(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }

    public void DisplayCountdown(int seconds)
    {
        DateTime endTime = GetEndTime(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(seconds--);
            Thread.Sleep(1000);
            if (seconds >= 9)
                Console.WriteLine("\b\b  \b\b");
            else
                Console.Write("\b");
        }
    }

    public DateTime GetEndTime(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        return endTime;
    }
}