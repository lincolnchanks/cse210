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
    }
}