class Menu
{
    public int DisplayMenu()
    {
        int response = 0;
        while (response < 1 || response > 9)
        {
            Console.WriteLine("1. Add Item to Storage");
            Console.WriteLine("2. List Items in Storage");
            Console.WriteLine("3. Save All Data");
            Console.WriteLine("4. Load Data From File");
            Console.WriteLine("5. Make Recipe");
            Console.WriteLine("6. Check Expiration Dates");
            Console.WriteLine("7. Check Calendar");
            Console.WriteLine("8. Make and Schedule Meal");
            Console.WriteLine("9. Quit");
            response = int.Parse(Console.ReadLine());
        }
        return response;
    }
    public int DisplayChooseIngredientMenu(Storage storage)
    {
        int count = 1;
        foreach(FoodItem foodItem in storage.GetContentsList())
        {
            Console.WriteLine($"{count}. {foodItem.GetName()}");
        }
        count -= 1;

        int response = 0;
        while (response < 1 || response > count)
        {
            Console.WriteLine("Choose an ingredient to add.");
            response = int.Parse(Console.ReadLine());
        }
        return response;
    }
}