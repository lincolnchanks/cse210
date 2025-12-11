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
        // This code needs to run each time a FoodItem is created. Currently, this code
        // constructs a Day object before any FoodItems are created. I need to add a method
        // to either the FoodItem or Day class that will add FoodItems to a Day object manually.
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
    // public Day(DateTime date, User user)
    // {
    //     _date = date;
    //     foreach (Storage storage in user.GetStoragePlaces())
    //     {
    //         foreach(FoodItem foodItem in storage.GetContentsList())
    //         {
    //             if (foodItem.GetExpirationDate() == _date)
    //             {
    //                 _expiringItems.Add(foodItem);
    //             }
    //         }
    //     }
    // }
    public void DisplayDay()
    {
        Console.WriteLine($"{_date.Year}/{_date.Month}/{_date.Day}");
        if (this._hasExpiringItems)
        {
            foreach(FoodItem item in _expiringItems)
            {
                Console.WriteLine($"Expiring today: {item.GetName()}");
            }
        }
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
    }
}