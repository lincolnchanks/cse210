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
    }
}