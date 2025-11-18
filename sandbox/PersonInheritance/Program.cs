class Program
{
    static void Main(string[] args)
    {
        Person johnny = new Person("Johnny", "West", 25, 165);
        Console.WriteLine(johnny.PersonInformation());
        johnny.SetAge(26);
        johnny.SetWeight(170);
        Console.WriteLine(johnny.PersonInformation());

        Police waxilliumLadrian = new Police("Coins, Guns", "Waxillium", "Ladrian", 45, 200);
        Console.WriteLine(waxilliumLadrian.GetPoliceInformation());
        Console.WriteLine(waxilliumLadrian.PersonInformation());

        Doctor doctorLegundo = new Doctor("Wooden Stake, Holy Water, Silver Sword", "Doctor", "Legundo", 50, 200);
        Console.WriteLine(doctorLegundo.GetDoctorInformation());
        Console.WriteLine(doctorLegundo.PersonInformation());
    }
}