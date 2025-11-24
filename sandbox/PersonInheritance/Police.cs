class Police : Person
{
    private string _weapons;
    public Police(string weapons, string firstName, string lastName, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    // public string GetPoliceInformation()
    // {
    //     // PersonInformation() is still accessible by the Police class.
    //     // This is because it's protected, not private.
    //     return $"{base.GetPersonInformation()}, Weapons: {_weapons}";
    // }

    public override string GetPersonInformation()
    { // We have to use base here or it will be recursive
        return $"{base.GetPersonInformation()}, Weapons: {_weapons}";
    }
}