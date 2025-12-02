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
        return 0;
    }
    // public int GetUserAction()
    // {
    //     int response = 0;

    //     Console.WriteLine("1. Create Goal");
    //     Console.WriteLine("2. List Goals");
    //     Console.WriteLine("3. Save Goals");
    //     Console.WriteLine("4. Load Goals");
    //     Console.WriteLine("5. Record Event.");
    //     Console.WriteLine("6. Quit");
    //     Console.Write("> ");

    //     // Adjust this so it filters out invalid input
    //     response = int.Parse(Console.ReadLine());
    //     return response;
    // }
}