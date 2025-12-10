class Day
{
    private DateTime _date;
    private List<FoodItem> _expiringItems;
    private Meal _breakfast;
    private Meal _lunch;
    private Meal _dinner;

    public Day(int year, int month, int day, User user)
    {
        // Checks each Food Item in each Storage container. If that item expires on this day, it
        // is added to the list of expiring items.
        _date = new DateTime(year, month, day);
        foreach (Storage storage in user.GetStoragePlaces())
        {
            foreach(FoodItem foodItem in storage.GetContentsList())
            {
                if (foodItem.GetExpirationDate() == _date)
                {
                    _expiringItems.Add(foodItem);
                }
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