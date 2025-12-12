class Day
{
    private DateTime _date;
    private List<FoodItem> _expiringItems = new List<FoodItem>();
    private bool _hasExpiringItems = false;
    private Meal _breakfast;
    private Meal _lunch;
    private Meal _dinner;

    public Day(int year, int month, int day, User user)
    {
        // Checks each Food Item in each Storage container. If that item expires on this day, it
        // is added to the list of expiring items.
        _date = new DateTime(year, month, day);
        // When a FoodItem is created it's automatically added to its expiration Day but only if
        // that day is in the next 14 days. This constructor should be modified so that every time
        // FoodItem data is loaded from a file, a new calendar object with corresponding Days will
        // be constructed.
        foreach (Storage storage in user.GetStoragePlaces())
        {
            foreach(FoodItem foodItem in storage.GetContentsList())
            {
                if (foodItem.GetExpirationDate() == _date)
                {
                    _expiringItems.Add(foodItem);
                    _hasExpiringItems = true;
                }
            }
        }
    }
    public void DisplayDay()
    {
        Console.WriteLine(GetDateString());
        if (this._hasExpiringItems)
        {
            foreach(FoodItem item in _expiringItems)
            {
                Console.WriteLine($"Expiring today: {item.GetName()}");
            }
        }
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public string GetDateString()
    {
        return $"{_date.Year}/{_date.Month}/{_date.Day}";
    }
    public void SetBreakfast(Meal breakfast)
    {
        
    }
    public void SetLunch(Meal lunch)
    {
        
    }
    public void SetDinner(Meal dinner)
    {
        
    }
    public void AddItemExpiration(FoodItem expiringItem)
    {
        _expiringItems.Add(expiringItem);
        if (!_hasExpiringItems)
        {
            _hasExpiringItems = true;
        }
    }
}