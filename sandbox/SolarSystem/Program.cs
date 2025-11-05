class Program
{
    static void Main()
    {
        // Console.WriteLine("Bonjour tout le monde!");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 3031.9;
        // mercury.DisplayPlanetInformation();

        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 7520.8;
        // venus.DisplayPlanetInformation();

        Planet jedas = new Planet();
        jedas._name = "Jedas";
        jedas._diameter = 7926.2;
        // jedas.DisplayPlanetInformation();

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem._solarSystem.Add(jedas);

        solarSystem.DisplaySolarSystem();

        // Planet dronik = new Planet();
        // dronik._name = "Dronik";

        // Planet khollen = new Planet();
        // khollen._name = "Khollen";

        // Planet kreda = new Planet();
        // kreda._name = "Kreda";

        // Planet vulcanica = new Planet();
        // Planet alkalia = new Planet();
    }
}