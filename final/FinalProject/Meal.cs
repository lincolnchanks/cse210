using System.Numerics;

class Meal
{
    // private List<FoodItem> _ingredients = new List<FoodItem>();
    // private List<int> _ingredientAmounts = new List<int>();
    private int _totalCalories = 0;
    private Recipe _recipe;
    private string _mealSlot;

    public Meal(Recipe recipe)
    {
        _recipe = recipe;
        
        // The Recipe already has this information stored, thus we don't need it right now.
        // _ingredients = _recipe.GetIngredientsList();
        // _ingredientAmounts = _recipe.GetAmountsList();
        
        foreach(FoodItem foodItem in _recipe.GetIngredientsList())
        {
            _totalCalories += foodItem.GetCalories();
        }
    }
    // public Recipe GetRecipe()
    // {
    //     return _recipe;
    // }
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
        for (int i = 0; i < _recipe.GetIngredientsList().Count; i++)
        {
            // Compare to each item in storage
            foreach(FoodItem item in storage.GetContentsList())
            {
                // Match the ingredient name to the item in storage
                if (_recipe.GetIngredientsList()[i].GetName() == item.GetName())
                {
                    // Are there enough servings in storage to remove the item?
                    if (_recipe.GetAmountsList()[i] <= item.GetNumServings())
                    {
                        // If so, remove that number of servings.
                        item.RemoveFromStorage(_recipe.GetAmountsList()[i], storage);
                    }
                    else
                    {
                        // If not, quit the function.
                        Console.WriteLine($"Not enough of {_recipe.GetIngredientsList()[i].GetName()} in storage.");
                        return;
                    }
                }
            }
        }
    }
    // public void AddIngredient(FoodItem ingredient, int ingredientAmount)
    // {
    //     _recipe.AddIngredient(ingredient, ingredientAmount);
    //     // _ingredients.Add(ingredient);
    //     // _ingredientAmounts.Add(ingredientAmount);
    //     _totalCalories += ingredient.GetCalories();
    // }
    // public void DisplayIngredients()
    // {
    //     foreach(FoodItem item in _recipe.GetIngredientsList())
    //     {
    //         item.DisplayFoodInformation();
    //     }
    //     foreach(int i in _recipe.GetAmountsList())
    //     {
    //         Console.WriteLine(i);
    //     }
    //     Console.WriteLine(_totalCalories);
    // }
}