using System;

namespace CSharp_Practice_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Josh's C# Practice Library!\nFeel free to look around and check out one of the exercises below!");
            GetMenuOptions();
            Console.Write("Select an exercise? ");
            NavigateRequest(Console.ReadLine());
        }

        private static void GetMenuOptions()
        {
            string[] options = { "1) Crappy Calculator" };

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }

        private static void NavigateRequest(string userRequest)
        {
            int selection;
            bool validRequest = Int32.TryParse(userRequest, out selection);
            if (validRequest)
            {
                switch (selection)
                {
                    case 1:
                        Calculate.Calculator();
                        break;
                    default:
                        MainMenu();
                        break;
                }
            }
            else
            {
                MainMenu();
            }
        }
    }
}
