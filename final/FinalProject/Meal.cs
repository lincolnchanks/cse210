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
    public Recipe GetRecipe()
    {
        return _recipe;
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
    public string GetMealSlot()
    {
        return _mealSlot;
    }
    public void ServeMeal(Storage storage)
    {
        // For each ingredient
        for (int i = 0; i < _ingredients.Count; i++)
        {
            // Compare to each item in storage
            foreach(FoodItem item in storage.GetContentsList())
            {
                // Match the ingredient name to the item in storage
                if (_ingredients[i].GetName() == item.GetName())
                {
                    // Are there enough servings in storage to remove the item?
                    if (_ingredientAmounts[i] <= item.GetNumServings())
                    {
                        // If so, remove that number of servings.
                        item.RemoveFromStorage(_ingredientAmounts[i], storage);
                    }
                    else
                    {
                        // If not, quit the function.
                        Console.WriteLine($"Not enough of {_ingredients[i].GetName()} in storage.");
                        return;
                    }
                }
            }
        }
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