class Day
{
    private DateTime _date;
    private List<FoodItem> _expiringItems;
    private Meal _breakfast;
    private Meal _lunch;
    private Meal _dinner;

    public Day(int year, int month, int day)
    {
        _date = new DateTime(year, month, day);
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
        
    }
}