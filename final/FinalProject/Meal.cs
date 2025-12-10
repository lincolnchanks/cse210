using System.Numerics;

class Meal
{
    private List<FoodItem> _ingredients = new List<FoodItem>();
    private List<int> _ingredientAmounts = new List<int>();
    private int _totalCalories = 0;
    private int _numServings;

    public Meal(List<FoodItem> ingredients, List<int> ingredientAmounts)
    {
        _ingredients = ingredients;
        _ingredientAmounts = ingredientAmounts;
        foreach(FoodItem foodItem in _ingredients)
        {
            _totalCalories += foodItem.GetCalories();
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