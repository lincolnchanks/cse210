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
    {
        foreach (FoodItem foodItem in _ingredients)
        {
            foodItem.DisplayFoodInformation();
        }
    }
}