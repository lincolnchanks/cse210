using System.Numerics;

class Recipe
{
    private List<FoodItem> _ingredients = new List<FoodItem>();
    private List<int> _ingredientAmounts = new List<int>();
    private string _recipeName;

    public Recipe(string name)
    {
        _recipeName = name;
    }
    public string GetRecipeName()
    {
        return _recipeName;
    }
    public void AddIngredient(FoodItem ingredient, int amount)
    {
        _ingredients.Add(ingredient);
        _ingredientAmounts.Add(amount);
    }
    public List<FoodItem> GetIngredientsList()
    {
        return _ingredients;
    }
    public List<int> GetAmountsList()
    {
        return _ingredientAmounts;
    }
    public void DisplayRecipe()
    { // TO-DO: Make this method better.
        Console.WriteLine($"Recipe: {_recipeName}");
        Console.WriteLine("Ingredients:");
        for (int i = 0; i < _ingredients.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_ingredients[i].GetName()} - {_ingredientAmounts[i]} serving(s)");
        }
        // foreach (FoodItem foodItem in _ingredients)
        // {
        //     foodItem.DisplayFoodInformation();
        // }
    }
    public string GetFileSystemString()
    {
        string fileString = $"Recipe#{_recipeName}#";
        foreach(FoodItem foodItem in _ingredients)
        {
            fileString += $"/{foodItem.GetName()}";
        }
        fileString += $"#";
        foreach(int amount in _ingredientAmounts)
        {
            fileString += $"/{amount}";
        }

        return fileString;
    }
}