using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        Storage testStorage = new Storage("Overall Storage"); // eventually there'll be a way
                                                            // to make your own storage.

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

                    FoodItem tempCurrentFoodItem = new FoodItem(tempFoodName, tempExpirYear, tempExpirMonth, tempExpirDay, tempFoodCalories, tempFoodNumServings, tempFoodPrice, tempFoodBrand);
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

                        FoodItem loadedFoodItem = new FoodItem(foodName, foodExpirYear, foodExpirMonth, foodExpirDay, foodCalories, foodNumServings, foodPrice, foodBrand);
                        testStorage.AddItem(loadedFoodItem);
                    }
                    break;
                case 5:
                    Console.WriteLine("Making a recipe.");
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
        FoodItem bread = new FoodItem("Bread", 2025, 12, 19, 300, 10, 2.98, "Grandma Sycamore's");
        // Console.WriteLine(bread.GetFileSystemString());
        // bread.DisplayFoodInformation();
        // bread.Expire();
        // bread.DisplayFoodInformation();

        // Storage fridge = new Storage("Fridge");
        // fridge.AddItem(bread);
        // fridge.DisplayInfo();

        FoodItem meatballs = new FoodItem("Meatballs", 2025, 12, 19, 300, 6, 12.43, "IDK Brand");

        List<FoodItem> testItems = new List<FoodItem>();
        testItems.Add(bread);
        testItems.Add(meatballs);

        List<int> testAmounts = new List<int>();
        testAmounts.Add(13);
        testAmounts.Add(24);

        Meal peachesAndMeatballs = new Meal(testItems, testAmounts);
        // peachesAndMeatballs.AddIngredient(meatballs, 24);
        peachesAndMeatballs.DisplayIngredients();
    }
}