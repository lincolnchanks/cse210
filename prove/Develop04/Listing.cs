class Listing : BaseActivity
{
    public Listing(string name, string description, int duration)
    : base(name, description, duration)
    {
        
    }

    public void RunListingActivity()
    {
        Console.WriteLine(GetStartMessage());

        

        Console.WriteLine(GetEndMessage());
    }
}