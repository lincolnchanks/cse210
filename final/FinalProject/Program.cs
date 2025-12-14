using System;
using System.Data;
// using static FoodItemLoadData;

// enum FoodItemLoadData {Name, ExpirYear, ExpirMonth, 
//     ExpirDay, Calories, NumServings, Price, Brand}

// Final Backlog:
//  1. Save Meal Dates and Slots
//  2. Add the Serve Meal Action
//  3. Combine similar methods inside the Day class.
//  4. Make the Menu more User-friendly with Console.Clear()'s.

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
        while (response != 8)
        {
            // Console.Clear();
            response = menu.DisplayMenu();

            switch (response)
            {
                case 1:
                    // ----------------------------------------------------------
                    // GET USER INPUT
                    // ----------------------------------------------------------

                    Console.WriteLine("Please enter the name of the food item.");
                    string tempFoodName = Console.ReadLine();

                    Console.WriteLine("Enter the expiration date (yyyy/mm/dd).");
                    string tempFoodExpirationDate = Console.ReadLine();
                    string[] dateData = tempFoodExpirationDate.Split("/"); // Put this code into the constructor?
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

                    // ----------------------------------------------------------
                    // CREATE FOODITEM OBJECT FROM PROVIDED DATA
                    // ----------------------------------------------------------

                    FoodItem tempCurrentFoodItem = new FoodItem(tempFoodName, tempExpirYear, 
                        tempExpirMonth, tempExpirDay, tempFoodCalories, tempFoodNumServings, 
                        tempFoodPrice, tempFoodBrand);
                    
                    // ----------------------------------------------------------
                    // ADD THE FOODITEM TO THE OVERALL STORAGE
                    // ----------------------------------------------------------
                    testStorage.AddItem(tempCurrentFoodItem);

                    // ----------------------------------------------------------
                    // ADD THE FOODITEM TO THE DAY ON WHICH IT EXPIRES
                    // ----------------------------------------------------------
                    foreach (Day day in calendar.GetDays())
                    {
                        if (day.GetDate() == tempCurrentFoodItem.GetExpirationDate())
                        {
                            day.AddItemExpiration(tempCurrentFoodItem);
                            break;
                        }
                    }
                    break;
                case 2:
                    // ----------------------------------------------------------
                    // DISPLAY EACH FOODITEM AND RECIPE
                    // ----------------------------------------------------------
                    testStorage.DisplayInfo();
                    foreach (Recipe recipe in lincoln.GetSavedRecipes())
                    {
                        recipe.DisplayRecipe();
                    }
                    break;
                case 3:
                    // ----------------------------------------------------------
                    // OPEN A FILE TO WRITE TO
                    // ----------------------------------------------------------
                    Console.WriteLine("Enter the filename to save to:");
                    string outputFileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(outputFileName))
                    {
                        // ----------------------------------------------------------
                        // WRITE EACH FOODITEM TO THE FILE
                        // ----------------------------------------------------------
                        foreach(FoodItem foodItem in testStorage.GetContentsList())
                        {
                            outputFile.WriteLine($"{foodItem.GetFileSystemString()}");
                        }
                        // ----------------------------------------------------------
                        // WRITE EACH RECIPE TO THE FILE
                        // ----------------------------------------------------------
                        foreach(Recipe recipe in lincoln.GetSavedRecipes())
                        {
                            outputFile.WriteLine($"{recipe.GetFileSystemString()}");
                        }
                    }
                    break;
                case 4:
                    // ----------------------------------------------------------
                    // MAKE A STRING ARRAY FROM EACH LINE IN THE FILE
                    // ----------------------------------------------------------
                    Console.WriteLine("Enter the filename to load from (this will override your current data):");
                    string inputFileName = Console.ReadLine();
                    string[] foodLines = System.IO.File.ReadAllLines(inputFileName);
                    testStorage = new Storage("Overall Storage");

                    foreach(string foodLine in foodLines)
                    {
                        // ----------------------------------------------------------
                        // SPLIT EACH LINE INTO SECTIONS AND CHECK THE INFOTYPE
                        // ----------------------------------------------------------
                        string[] foodLineInfo = foodLine.Split("#");
                        string infoType = foodLineInfo[0];

                        // ----------------------------------------------------------
                        // READ A FOODITEM FROM THE FILE
                        // ----------------------------------------------------------
                        if (infoType == "FoodItem")
                        {
                            // ----------------------------------------------------------
                            // PARSE THE CONSTRUCTOR INFO FOR THE FOODITEM
                            // ----------------------------------------------------------
                            string foodName = foodLineInfo[1];
                            int foodExpirYear = int.Parse(foodLineInfo[2]);
                            int foodExpirMonth = int.Parse(foodLineInfo[3]);
                            int foodExpirDay = int.Parse(foodLineInfo[4]);
                            int foodCalories = int.Parse(foodLineInfo[5]);

                            int foodNumServings = int.Parse(foodLineInfo[7]);
                            double foodPrice = double.Parse(foodLineInfo[8]);
                            string foodBrand = foodLineInfo[9];

                            // ----------------------------------------------------------
                            // CREATE A FOODITEM FROM THE PARSED DATA
                            // ----------------------------------------------------------
                            FoodItem loadedFoodItem = new FoodItem(foodName, foodExpirYear, 
                                foodExpirMonth, foodExpirDay, foodCalories, foodNumServings, 
                                foodPrice, foodBrand);
                            // ----------------------------------------------------------
                            // ADD IT TO STORAGE
                            // ----------------------------------------------------------
                            testStorage.AddItem(loadedFoodItem);
                            // ----------------------------------------------------------
                            // ADD IT TO ITS EXPIRATION DATE
                            // ----------------------------------------------------------
                            foreach (Day day in calendar.GetDays())
                            {
                                if (day.GetDate() == loadedFoodItem.GetExpirationDate())
                                {
                                    day.AddItemExpiration(loadedFoodItem);
                                    break;
                                }
                                // The last two steps are duplicated from case 1. Should we
                                // combine those two into the FoodItem constructor?
                            }
                        }
                        // TO-DO: When saving FoodItems, save ItemIDs with them so the user
                        // adding two items with the same name doesn't break the program
                        // (STRETCH GOAL!!!!)
                        // ----------------------------------------------------------
                        // READ A RECIPE FROM THE FILE
                        // ----------------------------------------------------------
                        else if (infoType == "Recipe")
                        {
                            // ----------------------------------------------------------
                            // GET RECIPE NAME AND CREATE A RECIPE WITH IT
                            // ----------------------------------------------------------
                            string fileRecipeName = foodLineInfo[1];
                            Recipe tempLoadedRecipe = new Recipe(fileRecipeName);

                            // ----------------------------------------------------------
                            // GET THE LISTS OF INGREDIENTS AND AMOUNTS
                            // ----------------------------------------------------------
                            string[] fileRecipeIngredients = foodLineInfo[2].Split("/");
                            string[] fileRecipeAmounts = foodLineInfo[3].Split("/");
                            // ----------------------------------------------------------
                            // FOR EACH INGREDIENT
                            // ----------------------------------------------------------
                            for (int i = 0; i < fileRecipeIngredients.Length; i++)
                            {
                                // ----------------------------------------------------------
                                // GET INGREDIENT NAME
                                // ----------------------------------------------------------
                                string tempIngredientName = fileRecipeIngredients[i];
                                foreach(FoodItem foodItem in testStorage.GetContentsList())
                                {
                                    // ----------------------------------------------------------
                                    // LOCATE THE MATCHING FOODITEM AND ADD IT TO THE RECIPE
                                    // ----------------------------------------------------------
                                    if (foodItem.GetName() == tempIngredientName)
                                    {
                                        tempLoadedRecipe.AddIngredient(foodItem, int.Parse(fileRecipeAmounts[i]));
                                        break;
                                    }
                                }
                            }
                            // ----------------------------------------------------------
                            // ADD THE RECIPE TO THE RECIPES LIST
                            // ----------------------------------------------------------
                            lincoln.AddRecipe(tempLoadedRecipe);
                        }
                    }
                    break;
                case 5:
                    // This creates a new Recipe object and allows the user to enter ingredients.
                    // TO-DO:
                        // Make recipes deletable
                        // Make recipes listable
                        // If there are no ingredients in the list, accommodate that
                    
                    // ----------------------------------------------------------
                    // GET RECIPE NAME
                    // ----------------------------------------------------------
                    Console.WriteLine("Enter the name of the recipe:");
                    string tempRecipeName = Console.ReadLine();

                    // ----------------------------------------------------------
                    // BUILD RECIPE
                    // ----------------------------------------------------------
                    Recipe currentRecipe = new Recipe(tempRecipeName);
                    bool done = false;
                    while (!done)
                    {
                        // ----------------------------------------------------------
                        // GET INGREDIENT AND AMOUNT, ADD TO THE RECIPE
                        // ----------------------------------------------------------
                        FoodItem currentIngredient = menu.DisplayChooseIngredientMenu(testStorage);

                        Console.WriteLine("Enter the amount of this ingredient:");
                        int currentIngredientAmount = int.Parse(Console.ReadLine());

                        currentRecipe.AddIngredient(currentIngredient, currentIngredientAmount);

                        // ----------------------------------------------------------
                        // LOOP IF THE USER ASKS TO
                        // ----------------------------------------------------------
                        Console.WriteLine("Continue? (Y/N)");
                        string finResponse = Console.ReadLine();
                        if (!(finResponse.ToLower() == "y"))
                        {
                            done = true;
                        }
                    }
                    // ----------------------------------------------------------
                    // ADD RECIPE TO USER'S LIST
                    // ----------------------------------------------------------
                    lincoln.AddRecipe(currentRecipe);
                    break;
                case 6:
                    // ----------------------------------------------------------
                    // DISPLAY EVERY DAY WITH ITS MEALS AND EXPIRATIONS
                    // ----------------------------------------------------------
                    calendar.DisplayCalendar();
                    break;
                case 7:
                // TO-DO:
                // If there are no recipes to choose from, accommodate that.
                    // --------------------------------------------------------------
                    // GET THE RECIPE TO TEMPLATE THE MEAL FROM, MAKE A MEAL FROM IT
                    // --------------------------------------------------------------
                    Recipe tempTemplateRecipe = menu.DisplayChooseRecipeMenu(lincoln);
                    Meal tempMeal = new Meal(tempTemplateRecipe);
                    
                    // ----------------------------------------------------------
                    // GET THE SCHEDULE DATE FROM THE USER
                    // ----------------------------------------------------------
                    Console.WriteLine($"Select the date for this meal (up to {calendar.GetDays()[calendar.GetDays().Count - 1].GetDateString()})");
                    string inputDateString = Console.ReadLine();
                    string[] inputDateData = inputDateString.Split("/");
                    int inputYear = int.Parse(inputDateData[0]);
                    int inputMonth = int.Parse(inputDateData[1]);
                    int inputDay = int.Parse(inputDateData[2]); // Date Parsing should be its own method.
                    
                    // ----------------------------------------------------------
                    // MAKE A TEMPLATE DAY.
                    // ----------------------------------------------------------
                    Day templateDay = new Day(inputYear, inputMonth, inputDay, lincoln);
                    int chosenMeal = menu.DisplayChooseMealMenu();
                    string chosenMealString;

                    // ----------------------------------------------------------
                    // ADD THE MEAL TO THE CHOSEN MEAL SLOT
                    // ----------------------------------------------------------
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
                    // -----------------------------------------------------------------------
                    // FIND MATCHING DAY IN CALENDAR. ADD MEAL DATA TO THAT DATE'S MEAL SLOT.
                    // -----------------------------------------------------------------------
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