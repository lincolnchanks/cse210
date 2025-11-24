class Doctor : Person
{
    private string _tools;
    public Doctor(string tools, string firstName, string lastName, int age, int weight) 
    : base(firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, Tools: {_tools}";
    }

    public override double GetSalary()
    {
        return 200000.01;
    }
}