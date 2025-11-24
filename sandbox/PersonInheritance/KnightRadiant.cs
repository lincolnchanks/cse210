class KnightRadiant : Person
{
    private int _ideal;
    private string _order;
    private string _primarySurge;
    private string _secondarySurge;
    public KnightRadiant(int ideal, string order, string firstName, string lastName, int age, 
        int weight, string primarySurge, string secondarySurge)
    : base(firstName, lastName, age, weight)
    {
        _ideal = ideal;
        _order = order;
        _primarySurge = primarySurge;
        _secondarySurge = secondarySurge;
    }

    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, Ideal: {_ideal}, Order: {_order}, Surges: {_primarySurge}, {_secondarySurge}.";
    }

    public override double GetSalary()
    {
        return 1000000.34;
    }
}