using System;
using System.Data;
// using static FoodItemLoadData;

// enum FoodItemLoadData {Name, ExpirYear, ExpirMonth, 
//     ExpirDay, Calories, NumServings, Price, Brand}

class Program
{
    static Calendar SetupCalendar(User user)
    // Could this be better used within the constructor for Calendar? Come to think of it,
    // I think so.
    {
        // Calendar calendar = new Calendar();
        List<Day> calendarDaysList = new List<Day>();

        // Take today's date and extract the year, month, and day.
        DateTime currentDate = DateTime.Today;
        int currYear = currentDate.Year;
        int currMonth = currentDate.Month;
        int currDay = currentDate.Day;
        // I believe this loops 30 times? So it'll block out the next 30 days.
        // Realistically, I don't think we care about food that expires 30 days from now.
        // At least, we can worry about that later when the program is more built up.
        for(int i = 0; i < 30; i++)
        {
            if (currMonth is 1 or 3 or 5 or 7 or 8 or 10 or 12)
            {
                if ((31 - currDay) > i)
                {
                    Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                    calendarDaysList.Add(tempDay);
                }
                else
                {
                    Day tempDay = new Day(currYear, currMonth + 1, i - (31 - currDay), user);
                    calendarDaysList.Add(tempDay);
                }
            }
            else if (currMonth is 4 or 6 or 9 or 11)
            {
                if ((30 - currDay) > i)
                {
                    Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                    calendarDaysList.Add(tempDay);
                }
                else
                {
                    Day tempDay = new Day(currYear, currMonth + 1, i - (30 - currDay), user);
                    calendarDaysList.Add(tempDay);
                }
            }
            else
            {
                if ((28 - currDay) > i)
                {
                    Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                    calendarDaysList.Add(tempDay);
                }
                else
                {
                    Day tempDay = new Day(currYear, currMonth + 1, i - (28 - currDay), user);
                    calendarDaysList.Add(tempDay);
                }
            }
        }
        Calendar calendar = new Calendar(calendarDaysList);
        return calendar;
    }

    static void Main(string[] args)
    {
        User lincoln = new User();

        Calendar calendar = SetupCalendar(lincoln);

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
                    // Add one food item to the storage list, based on user input.
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

                    FoodItem tempCurrentFoodItem = new FoodItem(tempFoodName, tempExpirYear, 
                        tempExpirMonth, tempExpirDay, tempFoodCalories, tempFoodNumServings, 
                        tempFoodPrice, tempFoodBrand);
                    testStorage.AddItem(tempCurrentFoodItem);
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
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to load from (this will override your current data):");
                    string inputFileName = Console.ReadLine();
                    string[] foodLines = System.IO.File.ReadAllLines(inputFileName);
                    testStorage = new Storage("Overall Storage");

                    foreach(string foodLine in foodLines)
                    {
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
                    }
                    break;
                case 5:
                    Console.WriteLine("Making a recipe.");
                    // This creates a new Recipe object and allows the user to enter ingredients.
                    // TO-DO:
                        // Make recipes saveable.
                        // Make recipes deletable
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
                    break;
                case 6:
                    Console.WriteLine("Checking Expiration Dates.");
                    break;
                case 7:
                    Console.WriteLine("Checking Calendar.");
                    // Displays each day with the food items expiring that day, plus each meal
                    // planned for it.
                    break;
                case 8:
                    Console.WriteLine("Making and Scheduling Meal.");
                    // TO-DO: Make meals from recipe templates.
                    Recipe tempTemplateRecipe = menu.DisplayChooseRecipeMenu(lincoln);

                    Meal tempMeal = new Meal(tempTemplateRecipe);

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