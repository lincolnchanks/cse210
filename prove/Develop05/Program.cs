using System;

class Program
{
    static void Main(string[] args)
    {
        User lincolnHanks = new User();
        Menu myMenu = new Menu();
        int response = 0;
        while (response != 6)
        {
            response = myMenu.GetUserAction();
            switch (response)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}