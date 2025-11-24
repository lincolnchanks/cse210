class Person
{
    private string _firstName;
    private string _lastName;
    private int _age; // If you make this protected, child classes don't need the setter methods.
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        if (age < 0 || age > 124)
        {
            Console.WriteLine("Invalid age.");
            _age = 0;
        }
        else
        {
            _age = age;
        }
        if (weight < 0 || weight > 300)
        {
            Console.WriteLine("Invalid weight.");
            _weight = 0;
        }
        else
        {
            _weight = weight;
        }
    }
    public virtual string GetPersonInformation()
    {
        return $"{_lastName}, {_firstName} / {_age} / {_weight} lbs.";
    }
    public void SetAge(int age)
    {
        if (age < 0)
        {
            _age = 0;
        }
        else
        {
            _age = age;
        }
    }
    public void SetWeight(int weight)
    {
        if (weight < 0)
        {
            _weight = 0;
        }
        else
        {
            _weight = weight;
        }
    }
    public void AgeUp()
    {
        _age ++;
    }
}