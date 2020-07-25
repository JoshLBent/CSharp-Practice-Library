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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to a Crappy Calculator!");
            bool calculateLoop = false;
            do
            {
                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();
                int num1;
                bool convert1 = Int32.TryParse(input1, out num1);
                if (convert1)
                {
                    Console.Write("Enter the operand you would like to use (+-*/): ");
                    string operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                    {
                        Console.Write("Enter the second number: ");
                        string input2 = Console.ReadLine();
                        int num2;
                        bool convert2 = Int32.TryParse(input2, out num2);
                        if (convert2)
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
        }
    }
}
