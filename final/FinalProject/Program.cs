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
                    foreach (Recipe recipe in lincoln.GetSavedRecipes())
                    {
                        recipe.DisplayRecipe();
                    }
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
                        string infoType = foodLineInfo[0];

                        // If it's a FoodItem, run this code to read it accordingly.
                        if (infoType == "FoodItem")
                        {
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
                        // TO-DO: When saving FoodItems, save ItemIDs with them so the user
                        // adding two items with the same name doesn't break the program
                        // (STRETCH GOAL!!!!)
                        else if (infoType == "Recipe")
                        {
                            string fileRecipeName = foodLineInfo[1];
                            Recipe tempLoadedRecipe = new Recipe(fileRecipeName);

                            string[] fileRecipeIngredients = foodLineInfo[2].Split("/");
                            string[] fileRecipeAmounts = foodLineInfo[3].Split("/");
                            for (int i = 0; i < fileRecipeIngredients.Length; i++)
                            {
                                string tempIngredientName = fileRecipeIngredients[i];
                                foreach(FoodItem foodItem in testStorage.GetContentsList())
                                {
                                    if (foodItem.GetName() == tempIngredientName)
                                    {
                                        tempLoadedRecipe.AddIngredient(foodItem, int.Parse(fileRecipeAmounts[i]));
                                        break;
                                    }
                                }
                            }
                            lincoln.AddRecipe(tempLoadedRecipe);
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
                    calendar.DisplayCalendar();
                    break;
                case 8:
                // TO-DO:
                // If there are no recipes to choose from, accommodate that.
                    Console.WriteLine("Making and Scheduling Meal.");
                    Recipe tempTemplateRecipe = menu.DisplayChooseRecipeMenu(lincoln);
                    Meal tempMeal = new Meal(tempTemplateRecipe);

                    Console.WriteLine($"Select the date for this meal (up to {calendar.GetDays()[calendar.GetDays().Count - 1].GetDateString()})");
                    string inputDateString = Console.ReadLine();
                    string[] inputDateData = inputDateString.Split("/");
                    int inputYear = int.Parse(inputDateData[0]);
                    int inputMonth = int.Parse(inputDateData[1]);
                    int inputDay = int.Parse(inputDateData[2]);

                    Day templateDay = new Day(inputYear, inputMonth, inputDay, lincoln);
                    int chosenMeal = menu.DisplayChooseMealMenu();
                    string chosenMealString;
                    switch (chosenMeal)
                    {
                        case 1:
                            Console.WriteLine("Breakfast");
                            templateDay.SetBreakfast(tempMeal);
                            chosenMealString = "Breakfast";
                            break;
                        case 2:
                            Console.WriteLine("Lunch");
                            templateDay.SetLunch(tempMeal);
                            chosenMealString = "Lunch";
                            break;
                        default:
                            Console.WriteLine("Dinner");
                            templateDay.SetDinner(tempMeal);
                            chosenMealString = "Dinner";
                            break;
                    }

                    // Puts the meal into the official calendar list.
                    foreach(Day day in calendar.GetDays())
                    {
                        if (day.GetDateString() == inputDateString)
                        {
                            switch (chosenMealString)
                            {
                                case "Breakfast":
                                    day.SetBreakfast(templateDay.GetBreakfast());
                                    break;
                                case "Lunch":
                                    day.SetLunch(templateDay.GetLunch());
                                    break;
                                default:
                                    day.SetDinner(templateDay.GetDinner());
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid date. Cannot plan beyond two weeks out.");
                        }
                    }
                    break;
            }
        }
    }
}