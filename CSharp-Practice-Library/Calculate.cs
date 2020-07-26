using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Practice_Library
{
    public class Calculate
    {
        public static void Calculator()
        {
            Console.Clear();
            Console.WriteLine("Welcome to a Crappy Calculator!");
            bool calculateLoop = false;
            do
            {
                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();
                int num1;
                if (Int32.TryParse(input1, out num1))
                {
                    Console.Write("Enter the operand you would like to use (+-*/): ");
                    string operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                    {
                        Console.Write("Enter the second number: ");
                        string input2 = Console.ReadLine();
                        int num2;
                        if (Int32.TryParse(input2, out num2))
                        {
                            int sum;
                            switch (operation)
                            {
                                case "+":
                                    sum = num1 + num2;
                                    Console.WriteLine("Result:\n{0} + {1} = {2}", num1, num2, sum);
                                    calculateLoop = true;
                                    break;
                                case "-":
                                    sum = num1 - num2;
                                    Console.WriteLine("Result:\n{0} - {1} = {2}", num1, num2, sum);
                                    calculateLoop = true;
                                    break;
                                case "*":
                                    sum = num1 * num2;
                                    Console.WriteLine("Result:\n{0} * {1} = {2}", num1, num2, sum);
                                    calculateLoop = true;
                                    break;
                                case "/":
                                    sum = num1 / num2;
                                    Console.WriteLine("Result:\n{0} / {1} = {2}", num1, num2, sum);
                                    calculateLoop = true;
                                    break;
                                default:
                                    Console.WriteLine("Something went wrong...");
                                    calculateLoop = true;
                                    break;
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter numerical values only.\nYou entered: " + input2);
                            calculateLoop = false;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid operator! (+-*/).\nYou entered: " + operation);
                        calculateLoop = false;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter numerical values only.\nYou entered: " + input1);
                    calculateLoop = false;
                }
            } while (!calculateLoop);
            Program.ReturnHome();
        }
    
        public static void TempCalc()
        {
            Console.Clear();
            Console.WriteLine("Welcome to a Touchy Temp Converter!\nWhat would you like to convert?");
            string[] conversions =
            {
                "1) \u00B0C -> \u00B0F & K",
                "2) \u00B0F -> \u00B0C & K",
                "3) K -> \u00B0F & \u00B0C"
            };
            foreach (string version in conversions)
            {
                Console.WriteLine(version);
            }
            Console.Write("Make a Selection: ");
            string selection = Console.ReadLine();
            if (selection == "1")
            {
                //c to f/k
                Console.Clear();
                Console.Write("Enter a temperature to convert from Celsius: ");

                // TODO: Build out 'Else' statement if unable to parse to double
                double celTemp;
                if (double.TryParse(Console.ReadLine(), out celTemp))
                {
                    Temps results = ConvertCelsius(celTemp);
                    Console.WriteLine("{0}\u00B0C is: {1} \u00B0F and {2} K", celTemp, results.temp1, results.temp2);
                }
            }
            else if (selection == "2")
            {
                //f to c/k
                Console.Clear();
                Console.Write("Enter a temperature to convert from Fahrenheit: ");

                // TODO: Build out 'Else' statement if unable to parse to double
                double fahrTemp;
                if (double.TryParse(Console.ReadLine(), out fahrTemp))
                {
                    Temps results = ConvertCelsius(fahrTemp);
                    Console.WriteLine("{0}\u00B0F is: {1} \u00B0C and {2} K", fahrTemp, results.temp1, results.temp2);
                }
            }
            else if (selection == "3")
            {
                //k to f/c
                Console.Clear();
                Console.Write("Enter a temperature to convert from Kelvin: ");

                // TODO: Build out 'Else' statement if unable to parse to double
                double kelTemp;
                if (double.TryParse(Console.ReadLine(), out kelTemp))
                {
                    Temps results = ConvertCelsius(kelTemp);
                    Console.WriteLine("{0}K is: {1} \u00B0F and {2} \u00B0C", kelTemp, results.temp1, results.temp2);
                }
            }
            else
            {
                // TODO: Build out 'Else' statement if menu choice 1-3 is not entered.
            }
        }

        struct Temps
        {
            public double temp1;
            public double temp2;
        }

        private static Temps ConvertCelsius(double cels)
        {
            Temps values = new Temps();
            // Fahrenheit
            values.temp1 = (cels * 1.8 + 32);
            // Kelvin
            values.temp2 = (cels + 273.15);
            return values;
        }
        private static Temps ConvertFahrenheit(double fahr)
        {
            Temps values = new Temps();
            // Celsius
            values.temp1 = ((fahr - 32) / 1.8);
            // Kelvin
            values.temp2 = (fahr + 459.67) * (5 / 9);
            return values;
        }
        private static Temps ConvertKelvin(double kel)
        {
            Temps values = new Temps();
            // Fahrenheit
            values.temp1 = (kel * (9 / 5) - 459.67);
            // Celsius
            values.temp2 = (kel - 273.15);
            return values;
        }

    }
}
