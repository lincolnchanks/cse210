class FoodItem
{
    private string _name;
    private DateTime _expirationDate;
    private int _calories;
    private bool _expired;
    private int _numServings;
    private double _price;
    private string _brand;
    public FoodItem(string name, int expirationYear, int expirationMonth, int expirationDay, int calories, int numServings, double price, string brand)
    {
        _name = name;
        _expirationDate = new DateTime(expirationYear, expirationMonth, expirationDay);
        _calories = calories;
        _expired = false;
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
        return $"FoodItem#{_name}#{_expirationDate}#{_calories}#{_expired}#{_numServings}#{_price}#{_brand}";
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