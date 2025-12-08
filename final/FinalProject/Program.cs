using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        FoodItem bread = new FoodItem("Bread", 2025, 12, 19, 300, 10, 2.98, "Grandma Sycamore's");
        bread.DisplayFoodInformation();
        bread.Expire();
        bread.DisplayFoodInformation();

        Storage fridge = new Storage("Fridge");
        fridge.AddItem(bread);
        fridge.DisplayInfo();

        FoodItem meatballs = new FoodItem("Meatballs", 2025, 12, 19, 300, 6, 12.43, "IDK Brand");

        Meal peachesAndMeatballs = new Meal();
        peachesAndMeatballs.AddIngredient(meatballs, 24);
        peachesAndMeatballs.DisplayIngredients();
    }
}