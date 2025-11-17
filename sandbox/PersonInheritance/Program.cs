class Program
{
    static void Main(string[] args)
    {
        Person johnny = new Person("Johnny", "West", 25, 165);
        Console.WriteLine(johnny.PersonInformation());
        johnny.SetAge(26);
        johnny.SetWeight(170);
        Console.WriteLine(johnny.PersonInformation());
    }
}