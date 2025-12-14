using System.Numerics;

class Meal
{
    private List<FoodItem> _ingredients = new List<FoodItem>();
    private List<int> _ingredientAmounts = new List<int>();
    private int _totalCalories = 0;
    private Recipe _recipe;
    private string _mealSlot;

    public Meal(Recipe recipe)
    {
        _recipe = recipe;
        
        _ingredients = _recipe.GetIngredientsList();
        _ingredientAmounts = _recipe.GetAmountsList();
        
        foreach(FoodItem foodItem in _ingredients)
        {
            _totalCalories += foodItem.GetCalories();
        }
    }
    public string GetMealName()
    {
        return _recipe.GetRecipeName();
    }
    public void SetMealSlot(string mealSlot)
    {
        _mealSlot = mealSlot;
    }
    public string GetFileSystemString(Day day)
    {
        return $"ScheduledMeal#{_recipe.GetRecipeName()}#{day.GetDateString()}#{_mealSlot}";
    }
    public void RemoveItemsFromStorage(Storage storage)
    {
        
    }
    public void AddIngredient(FoodItem ingredient, int ingredientAmount)
    {
        _ingredients.Add(ingredient);
        _ingredientAmounts.Add(ingredientAmount);
        _totalCalories += ingredient.GetCalories();
    }
    public void RemoveIngredient(FoodItem ingredient, int ingredientAmount, int ingredientCalories)
    {
        
    }
    public void DisplayIngredients()
    {
        foreach(FoodItem item in _ingredients)
        {
            item.DisplayFoodInformation();
        }
        foreach(int i in _ingredientAmounts)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(_totalCalories);
    }
}