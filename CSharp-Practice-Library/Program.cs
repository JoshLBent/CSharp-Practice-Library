using System;

namespace CSharp_Practice_Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Josh's C# Practice Library!\nFeel free to look around and check out one of the exercises below!");
            GetMenuOptions();
            Console.Write("Select an exercise? ");
            NavigateRequest(Console.ReadLine());
        }

        private static void GetMenuOptions()
        {
            string[] options = 
            { 
                "1) Crappy Calculator",
                "2) Touchy Temp Converter"
            };

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
                    case 2:
                        Calculate.TempCalc();
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

        public static void ReturnHome()
        {
            Console.Write("Would you like to return to the Main Menu? (Y/N) ");
            string input = Console.ReadLine().ToUpper();
            if (input == "Y" || input == "YES")
            {
                MainMenu();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
