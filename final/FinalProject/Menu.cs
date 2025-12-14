class Menu
{
    public int DisplayMenu()
    { // ONE MORE ACTION: SERVE MEAL
        // THIS ONE REMOVES THE FOOD AMOUNTS FROM THE FOOD STORAGE.
        int response = 0;
        while (response < 1 || response > 9)
        {
            Console.WriteLine("1. Add Item to Storage");
            Console.WriteLine("2. List Items in Storage");
            Console.WriteLine("3. Save All Data");
            Console.WriteLine("4. Load Data From File");
            Console.WriteLine("5. Make Recipe");
            Console.WriteLine("6. Check Calendar");
            Console.WriteLine("7. Make and Schedule Meal");
            Console.WriteLine("8. Serve Meal");
            Console.WriteLine("9. Quit");
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input must be an integer between 1 and 9.");
            }
        }
        return response;
    }
    public FoodItem DisplayChooseIngredientMenu(Storage storage)
    {
        int count = 1;
        foreach(FoodItem foodItem in storage.GetContentsList())
        {
            Console.WriteLine($"{count}. {foodItem.GetName()}");
            count++;
        }
        count -= 1;

        int chosenFoodItem = 0;
        while (chosenFoodItem < 1 || chosenFoodItem > count)
        {
            Console.WriteLine("Choose an ingredient to add.");
            try
            {
                chosenFoodItem = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"Input must be an integer between 1 and {count}.");
            }
        }
        return storage.GetContentsList()[chosenFoodItem - 1];
    }
    public Recipe DisplayChooseRecipeMenu(User user)
    {
        int count = 1;
        foreach(Recipe savedRecipe in user.GetSavedRecipes())
        {
            Console.WriteLine($"{count}. {savedRecipe.GetRecipeName()}");
            count++;
        }
        count -= 1;

        int chosenRecipe = 0;
        while (chosenRecipe < 1 || chosenRecipe > count)
        {
            Console.WriteLine($"Choose a recipe to base this off of.");
            try
            {
                chosenRecipe = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"Input must be an integer between 1 and {count}.");
            }
        }
        return user.GetSavedRecipes()[chosenRecipe - 1];
    }
    public int DisplayChooseMealSlotMenu()
    {
        int chosenMeal = 0;
        while (chosenMeal < 1 || chosenMeal > 3)
        {
            Console.WriteLine("Select which meal to schedule this for:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            try
            {
                chosenMeal = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input must be an integer between 1 and 3.");
            }
        }
        return chosenMeal;
    }
    public int DisplayChooseScheduledMealMenu(Calendar calendar)
    {
        int chosenScheduledMeal = 0;
        int count = 0;
        // List<Meal> tempMealsList = new List<Meal>();
        Console.WriteLine("Choose a meal to serve:");
        foreach(Day day in calendar.GetDays())
        {
            foreach(Meal meal in day.GetMeals())
            {
                count++;
                // tempMealsList.Add(meal);
                Console.WriteLine($"{count}. {meal.GetMealName()} ({day.GetDateString()}, {meal.GetMealSlot()})");
            }
        }
        while (chosenScheduledMeal < 1 || chosenScheduledMeal > count)
        {
            try
            {
                chosenScheduledMeal = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"Input must be an integer between 1 and {count}.");
            }
        }
        
        return chosenScheduledMeal;
        // Meal chosenMeal = tempMealsList[chosenScheduledMeal - 1];

        // return chosenMeal;
    }
}