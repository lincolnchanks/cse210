using System;
using System.Data;
// using static FoodItemLoadData;

// enum FoodItemLoadData {Name, ExpirYear, ExpirMonth, 
//     ExpirDay, Calories, NumServings, Price, Brand}

class Program
{
    static void Main(string[] args)
    {
        User lincoln = new User();

        Calendar calendar = new Calendar(lincoln);

        Menu menu = new Menu();
        
        Storage testStorage = new Storage("Overall Storage"); // eventually there'll be a way
                                                            // to make your own storage.
        lincoln.AddStoragePlace(testStorage);

        int response = 0;
        while (response != 9)
        {
            // Console.Clear();
            response = menu.DisplayMenu();

            switch (response)
            {
                case 1:
                    // Getting user input
                    Console.WriteLine("Please enter the name of the food item.");
                    string tempFoodName = Console.ReadLine();

                    Console.WriteLine("Enter the expiration date (yyyy/mm/dd).");
                    string tempFoodExpirationDate = Console.ReadLine();
                    string[] dateData = tempFoodExpirationDate.Split("/");
                    int tempExpirYear = int.Parse(dateData[0]);
                    int tempExpirMonth = int.Parse(dateData[1]);
                    int tempExpirDay = int.Parse(dateData[2]);
                    
                    Console.WriteLine("Enter the number of calories.");
                    int tempFoodCalories = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Enter the number of servings.");
                    int tempFoodNumServings = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Enter the price.");
                    double tempFoodPrice = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Enter the brand.");
                    string tempFoodBrand = Console.ReadLine();

                    // Creating Item
                    FoodItem tempCurrentFoodItem = new FoodItem(tempFoodName, tempExpirYear, 
                        tempExpirMonth, tempExpirDay, tempFoodCalories, tempFoodNumServings, 
                        tempFoodPrice, tempFoodBrand);
                    
                    // Adding to storage
                    testStorage.AddItem(tempCurrentFoodItem);

                    foreach (Day day in calendar.GetDays())
                    {
                        // Console.WriteLine("Day");
                        // Console.WriteLine(day.GetDate() == tempCurrentFoodItem.GetExpirationDate());
                        if (day.GetDate() == tempCurrentFoodItem.GetExpirationDate())
                        {
                            day.AddItemExpiration(tempCurrentFoodItem);
                            break;
                        }
                    }
                    break;
                case 2:
                    // Display each food item in the storage container.
                    testStorage.DisplayInfo();
                    break;
                case 3:
                    Console.WriteLine("Enter the filename to save to:");
                    string outputFileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(outputFileName))
                    {
                        foreach(FoodItem foodItem in testStorage.GetContentsList())
                        {
                            outputFile.WriteLine($"{foodItem.GetFileSystemString()}");
                        }
                        // FoodItems are written out regardless of order. Recipes are not.
                        foreach(Recipe recipe in lincoln.GetSavedRecipes())
                        {
                            outputFile.WriteLine($"{recipe.GetFileSystemString()}");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to load from (this will override your current data):");
                    string inputFileName = Console.ReadLine();
                    string[] foodLines = System.IO.File.ReadAllLines(inputFileName);
                    testStorage = new Storage("Overall Storage");

                    foreach(string foodLine in foodLines)
                    {
                        // TO-DO: Make recipes loadable.
                        string[] foodLineInfo = foodLine.Split("#");

                        string foodName = foodLineInfo[1];
                        int foodExpirYear = int.Parse(foodLineInfo[2]);
                        int foodExpirMonth = int.Parse(foodLineInfo[3]);
                        int foodExpirDay = int.Parse(foodLineInfo[4]);
                        int foodCalories = int.Parse(foodLineInfo[5]);

                        int foodNumServings = int.Parse(foodLineInfo[7]);
                        double foodPrice = double.Parse(foodLineInfo[8]);
                        string foodBrand = foodLineInfo[9];

                        FoodItem loadedFoodItem = new FoodItem(foodName, foodExpirYear, 
                            foodExpirMonth, foodExpirDay, foodCalories, foodNumServings, 
                            foodPrice, foodBrand);
                        testStorage.AddItem(loadedFoodItem);
                        foreach (Day day in calendar.GetDays())
                        {
                            if (day.GetDate() == loadedFoodItem.GetExpirationDate())
                            {
                                day.AddItemExpiration(loadedFoodItem);
                                break;
                            }
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Making a recipe.");
                    // This creates a new Recipe object and allows the user to enter ingredients.
                    // TO-DO:
                        // Make recipes deletable
                        // Make recipes listable
                        // If there are no ingredients in the list, accommodate that
                    Console.WriteLine("Enter the name of the recipe:");
                    string tempRecipeName = Console.ReadLine();

                    Recipe currentRecipe = new Recipe(tempRecipeName);
                    bool done = false;
                    while (!done)
                    {
                        FoodItem currentIngredient = menu.DisplayChooseIngredientMenu(testStorage);
                        Console.WriteLine("Enter the amount of this ingredient:");
                        int currentIngredientAmount = int.Parse(Console.ReadLine());
                        currentRecipe.AddIngredient(currentIngredient, currentIngredientAmount);
                        Console.WriteLine("Continue? (Y/N)");
                        string finResponse = Console.ReadLine();
                        if (!(finResponse.ToLower() == "y"))
                        {
                            done = true;
                        }
                    }
                    currentRecipe.DisplayRecipe();
                    lincoln.AddRecipe(currentRecipe); // This should make recipes saveable.
                    break;
                case 6:
                    Console.WriteLine("Checking Expiration Dates.");
                    break;
                case 7:
                    Console.WriteLine("Checking Calendar.");
                    // Displays each day with the food items expiring that day, plus each meal
                    // planned for it.
                    // What if we run the calendar constructor every time this command is run?
                    break;
                case 8:
                // TO-DO:
                // If there are no recipes to choose from, accommodate that.
                    Console.WriteLine("Making and Scheduling Meal.");
                    Recipe tempTemplateRecipe = menu.DisplayChooseRecipeMenu(lincoln);

                    Console.WriteLine($"Select the date for this meal (up to {calendar.GetDays()[calendar.GetDays().Count - 1].GetDateString()})");
                    string inputDateString = Console.ReadLine();

                    string[] inputDateData = inputDateString.Split("/");
                    int inputExpirYear = int.Parse(inputDateData[0]);
                    int inputExpirMonth = int.Parse(inputDateData[1]);
                    int inputExpirDay = int.Parse(inputDateData[2]);

                    Meal tempMeal = new Meal(tempTemplateRecipe);
                    int chosenMeal = menu.DisplayChooseMealMenu();
                    switch (chosenMeal)
                    {
                        case 1:
                            Console.WriteLine("Breakfast");
                            break;
                        case 2:
                            Console.WriteLine("Lunch");
                            break;
                        case 3:
                            Console.WriteLine("Dinner");
                            break;
                    }

                    // You can only make meals from recipes.

                    // After the meal is created you are prompted to choose a day to
                    // schedule it onto.
                    break;
            }
        }

        // Recipe recipe1 = new Recipe("JKJK");

        calendar.DisplayCalendar();

        // DateTime currentDate = DateTime.Today;
        // Console.WriteLine(currentDate);

        // Console.WriteLine("Hello FinalProject World!");
        // FoodItem bread = new FoodItem("Bread", 2025, 12, 19, 300, 10, 2.98, "Grandma Sycamore's");
        // Console.WriteLine(bread.GetFileSystemString());
        // bread.DisplayFoodInformation();
        // bread.Expire();
        // bread.DisplayFoodInformation();

        // Storage fridge = new Storage("Fridge");
        // fridge.AddItem(bread);
        // fridge.DisplayInfo();

        // FoodItem meatballs = new FoodItem("Meatballs", 2025, 12, 19, 300, 6, 12.43, "IDK Brand");

        // recipe1.AddIngredient(bread, 10);
        // recipe1.AddIngredient(meatballs, 12);

        // Console.WriteLine(recipe1.GetFileSystemString());

        // List<FoodItem> testItems = new List<FoodItem>();
        // testItems.Add(bread);
        // testItems.Add(meatballs);

        // List<int> testAmounts = new List<int>();
        // testAmounts.Add(13);
        // testAmounts.Add(24);

        // Meal peachesAndMeatballs = new Meal(testItems, testAmounts);
        // // peachesAndMeatballs.AddIngredient(meatballs, 24);
        // peachesAndMeatballs.DisplayIngredients();
    }
}