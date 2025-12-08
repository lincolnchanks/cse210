using System.Numerics;

class Meal
{
    private List<FoodItem> _ingredients = new List<FoodItem>();
    private List<int> _ingredientAmounts = new List<int>();
    private int _totalCalories = 0;
    private int _numServings;

    public void RemoveItemsFromStorage(Storage storage)
    {
        
    }
    public void AddIngredient(FoodItem ingredient, int ingredientAmount, int ingredientCalories)
    {
        _ingredients.Add(ingredient);
        _ingredientAmounts.Add(ingredientAmount);
        _totalCalories += ingredientCalories;
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