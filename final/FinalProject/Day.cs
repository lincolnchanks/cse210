class Day
{
    private DateTime _date;
    private List<FoodItem> _expiringItems = new List<FoodItem>();
    private bool _hasExpiringItems = false;
    private List<Meal> _scheduledMeals = new List<Meal>();
    private Meal _breakfast;
    private Meal _lunch;
    private Meal _dinner;
    private bool _breakfastAssigned = false;
    private bool _lunchAssigned = false;
    private bool _dinnerAssigned = false;

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
        // Date String
        Console.WriteLine(GetDateString());
        // Expiring Items
        if (this._hasExpiringItems)
        {
            foreach(FoodItem item in _expiringItems)
            {
                Console.WriteLine($"Expiring today: {item.GetName()}");
            }
        }
        // Display Meals
        if (_breakfastAssigned)
        {
            Console.WriteLine($"Breakfast: {_breakfast.GetMealName()}");
        }
        if (_lunchAssigned)
        {
            Console.WriteLine($"Lunch: {_lunch.GetMealName()}");
        }
        if (_dinnerAssigned)
        {
            Console.WriteLine($"Dinner: {_dinner.GetMealName()}");
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
        _breakfast = breakfast;
        _breakfastAssigned = true;
        _scheduledMeals.Add(breakfast);
        // breakfast.SetMealSlot("Breakfast");
    }
    public void SetLunch(Meal lunch)
    {
        _lunch = lunch;
        _lunchAssigned = true;
        _scheduledMeals.Add(lunch);
        // lunch.SetMealSlot("Lunch");
    }
    public void SetDinner(Meal dinner)
    {
        _dinner = dinner;
        _dinnerAssigned = true;
        _scheduledMeals.Add(dinner);
        // dinner.SetMealSlot("Dinner");
    }
    public List<Meal> GetMeals()
    {
        return _scheduledMeals;
    }
    public Meal GetBreakfast()
    {
        return _breakfast;
    }
    public Meal GetLunch()
    {
        return _lunch;
    }
    public Meal GetDinner()
    {
        return _dinner;
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