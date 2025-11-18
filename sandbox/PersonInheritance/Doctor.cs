class Doctor : Person
{
    string _tools;
    public Doctor(string tools, string firstName, string lastName, int age, int weight) 
    : base(firstName, lastName, age, weight)
    {
        _tools = tools;
    }
    public string GetDoctorInformation()
    {
        return $"{PersonInformation()}, Tools: {_tools}";
    }
}