class Listing : BaseActivity
{
    private string[] _prompts = [
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public Listing(string name, string description, int duration)
    : base(name, description, duration)
    {
        
    }

    public void RunListingActivity()
    {
        Console.WriteLine(GetStartMessage());
        Console.WriteLine(GetDescription());

        Random promptGen = new Random();
        int promptIndex = promptGen.Next(5);
        string currentPrompt = _prompts[promptIndex];
        Console.WriteLine(currentPrompt);


        Console.WriteLine(GetEndMessage());
    }
}