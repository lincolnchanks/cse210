class FoodItem
{
    private string _name;
    private DateTime _expirationDate;
    private int _expirationYear;
    private int _expirationMonth;
    private int _expirationDay;
    private int _calories;
    private bool _expired;
    private int _numServings;
    private double _price;
    private string _brand;
    public FoodItem(string name, int expirationYear, int expirationMonth, int expirationDay, int calories, int numServings, double price, string brand)
    {
        DateTime currentDate = DateTime.Today;
        _name = name;
        _expirationDate = new DateTime(expirationYear, expirationMonth, expirationDay);
        _expirationYear = expirationYear;
        _expirationMonth = expirationMonth;
        _expirationDay = expirationDay;
        _calories = calories;
        if (currentDate < _expirationDate)
        {
            _expired = false;
        }
        else
        {
            _expired = true;
            // if (currentDate == _expirationDate) Add some behavior for when food is expiring today.
        }
        _numServings = numServings;
        _price = price;
        _brand = brand;
    }
    public void Expire() // this needs to be called by some sort of refresh method, that checks every day when the user signs in.
    {
        if (!_expired)
        {
            _expired = true;
        }
    }
    public string GetFileSystemString()
    {
        return $"FoodItem#{_name}#{_expirationYear}#{_expirationMonth}#{_expirationDay}#{_calories}#{_expired}#{_numServings}#{_price}#{_brand}";
    }
    public string GetName()
    {
        return _name;
    }
    public void DisplayFoodItem()
    {
        
    }
    public void RemoveFromStorage(int numServingsRemoved)
    {
        
    }
    public void ScheduleItem()
    {
        
    }
    public int GetCalories()
    {
        return _calories;
    }
    public void DisplayFoodInformation()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Expiration Date: {_expirationDate}");
        Console.WriteLine($"Calories Per Serving: {_calories}");
        Console.WriteLine($"Expired: {_expired}");
        Console.WriteLine($"Number of Servings: {_numServings}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Brand: {_brand}");
    }
}