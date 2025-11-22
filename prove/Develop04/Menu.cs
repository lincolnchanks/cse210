class Menu
{
    public int DisplayMenu()
    {
        int response = 0;
        while (response < 1 || response > 4)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
        }
        try
        {
            response = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please enter a number between 1 and 4.");
        }
        
        return response;
    }
}