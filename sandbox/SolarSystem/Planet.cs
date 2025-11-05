class Planet
{
    public string _name = ""; //This has a value
    public double _diameter; //This has a null value
    
    public void DisplayPlanetInformation()
    {
        Console.WriteLine($"Planet name: {_name}, diameter: {_diameter}");
    }
}