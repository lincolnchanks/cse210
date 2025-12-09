class Storage
{
    private string _name;
    private List<FoodItem> _contents = new List<FoodItem>();

    public Storage(string name)
    {
        _name = name;
    }
    public void AddItem(FoodItem item)
    {
        _contents.Add(item);
    }
    public List<FoodItem> GetContentsList()
    {
        return _contents;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Items:");
        foreach(FoodItem item in _contents)
        {
            item.DisplayFoodInformation();
        }
    }
}