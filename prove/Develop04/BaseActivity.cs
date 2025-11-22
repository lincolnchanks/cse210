class BaseActivity
{
    private string _name = "";
    protected string _description = "";
    protected int _duration;
    // private string _startMessage = "Welcome to the Mindfulness activity!";
    // private string _endMessage = "End message";

    public BaseActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    public void RunActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        DisplayAnimation();
        DisplayCountdown(10);
    }

    public void DisplayAnimation()
    {
        string animationString = "\\|/-";
        int sleepTime = 250;
        int index = 0;
        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }

    public void DisplayCountdown(int seconds)
    {
        DateTime endTime = GetEndTime();
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

    public DateTime GetEndTime()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        return endTime;
    }
}