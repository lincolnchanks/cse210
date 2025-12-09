using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        int response = 0;
        while (response != 9)
        {
            // Console.Clear();
            response = menu.DisplayMenu();

            switch (response)
            {
                case 1:
                    Console.WriteLine("Adding Item to storage.");
                    break;
                case 2:
                    Console.WriteLine("Listing Items in Storage.");
                    break;
                case 3:
                    Console.WriteLine("Saving All Data.");
                    break;
                case 4:
                    Console.WriteLine("Loading Data from file.");
                    break;
                case 5:
                    Console.WriteLine("Making a recipe.");
                    break;
                case 6:
                    Console.WriteLine("Checking Expiration Dates.");
                    break;
                case 7:
                    Console.WriteLine("Checking Calendar.");
                    break;
                case 8:
                    Console.WriteLine("Making and Scheduling Meal.");
                    // When making a meal, you can make it from a recipe
                    // or add a new set of ingredients. After a meal is
                    // created with the second option, you have the option of
                    // saving its ingredients as a recipe.

                    // Meal could inherit from Recipe!! (maybe??)

                    // After the meal is created you are prompted to choose a day to
                    // schedule it onto.
                    break;
            }
        }







        // Console.WriteLine("Hello FinalProject World!");
        // FoodItem bread = new FoodItem("Bread", 2025, 12, 19, 300, 10, 2.98, "Grandma Sycamore's");
        // bread.DisplayFoodInformation();
        // bread.Expire();
        // bread.DisplayFoodInformation();

        // Storage fridge = new Storage("Fridge");
        // fridge.AddItem(bread);
        // fridge.DisplayInfo();

        // FoodItem meatballs = new FoodItem("Meatballs", 2025, 12, 19, 300, 6, 12.43, "IDK Brand");

        // Meal peachesAndMeatballs = new Meal();
        // peachesAndMeatballs.AddIngredient(meatballs, 24);
        // peachesAndMeatballs.DisplayIngredients();
    }
}