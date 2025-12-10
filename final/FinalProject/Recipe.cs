using System.Numerics;

class Recipe
{
    private List<FoodItem> _ingredients = new List<FoodItem>();
    private List<int> _ingredientAmounts = new List<int>();

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
}