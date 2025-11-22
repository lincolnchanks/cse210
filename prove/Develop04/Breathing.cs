using System.ComponentModel;

class Breathing : BaseActivity
{
    public Breathing(string name, string description, int duration) 
    : base(name, description, duration)
    {
        
    }

    public void RunBreathingActivity()
    {
        Console.WriteLine(GetDuration());
        DateTime endTime = GetEndTime();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            DisplayCountdown(4);
            Console.WriteLine("Breathe out...");
            DisplayCountdown(6);
        }
    }
}