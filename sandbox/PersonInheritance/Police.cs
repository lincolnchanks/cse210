class Police : Person
{
    private string _weapons;
    public Police(string weapons, string firstName, string lastName, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string GetPersonInformation()
    { // We have to use base here or it will be recursive
        return $"{base.GetPersonInformation()}, Weapons: {_weapons}";
    }
}