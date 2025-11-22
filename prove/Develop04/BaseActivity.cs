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
    
    public void RunActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        DisplayAnimation();
        DisplayCountdown();
    }

    public void DisplayAnimation()
    {
        string animationString = "\\|/-";
        int sleepTime = 250;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }

    public void DisplayCountdown()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(_duration--);
            Thread.Sleep(1000);
            if (_duration >= 9)
                Console.WriteLine("\b\b  \b\b");
            else
                Console.Write("\b");
        }
    }
}