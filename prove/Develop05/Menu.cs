class Menu
{
    public int DisplayMenu()
    {
        int response = 0;

        while(response < 1 || response > 6)
        {
            // Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input must be an integer value between 1 and 6.");
            }
        }
        return response;
    }
    public int DisplayCreateGoalMenu()
    {
        int response = 0;

        while (response < 1 || response > 3)
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input must be an integer value between 1 and 6.");
            }
        }
        return response;
    }
}