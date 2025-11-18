class Surgeon : Doctor
{
    private string _title;
    public Surgeon(string title, string tools, string firstName, string lastName, int age, int weight)
    : base(tools, firstName, lastName, age, weight)
    {
        _title = title;
    }

    public string GetSurgeonInformation()
    {
        return $"{GetDoctorInformation()}, Title: {_title}";
    }
}