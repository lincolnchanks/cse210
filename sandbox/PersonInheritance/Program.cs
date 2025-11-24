class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
    }
    static void Main(string[] args)
    {
        Person johnny = new Person("Johnny", "West", 25, 165);
        Console.WriteLine(johnny.GetPersonInformation());
        johnny.SetAge(26);
        johnny.SetWeight(170);
        Console.WriteLine(johnny.GetPersonInformation());

        Police waxilliumLadrian = new Police("Coins, Guns", "Waxillium", "Ladrian", 45, 200);
        Console.WriteLine(waxilliumLadrian.GetPersonInformation());
        // Console.WriteLine(waxilliumLadrian.PersonInformation());

        Doctor doctorLegundo = new Doctor("Wooden Stake, Holy Water, Silver Sword", "Doctor", 
            "Legundo", 50, 200);
        Console.WriteLine(doctorLegundo.GetPersonInformation());
        // Console.WriteLine(doctorLegundo.PersonInformation());
        doctorLegundo.AgeUp();
        doctorLegundo.SetWeight(215);
        Console.WriteLine(doctorLegundo.GetPersonInformation());

        KnightRadiant kaladinStormblessed = new KnightRadiant(5, "Windrunner", "Kaladin", 
            "Stormblessed", 20, 200, "Adhesion", "Gravitation");
        
        Surgeon kaladinSurgeon = new Surgeon("Bridgeboy", "Shardspear", "Kaladin",
            "Stormblessed", 20, 200);
        
        Console.WriteLine("\n\n\n\n");

        // Polymorphism: In Programming, different behavior depending on context.

        // Because of inheritance, you can add all of these child objects of Person to a list of Persons.
        List<Person> myPeople = new List<Person>();
        myPeople.Add(johnny);
        myPeople.Add(waxilliumLadrian);
        myPeople.Add(doctorLegundo);
        myPeople.Add(kaladinStormblessed);
        myPeople.Add(kaladinSurgeon);

        // Because of inheritance you can also count these objects as instances of Person for any
        // other code example.
        foreach(Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }
}