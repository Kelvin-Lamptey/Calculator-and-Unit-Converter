using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_and_Unit_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You are welcome to my Calcuator and Unit Converter App!!");
                Console.WriteLine("Select an option.");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Convert");
                Console.WriteLine("3. Exit");

                Console.Write("Choose: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Select a choice");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Substract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("3. Divide");
                    Console.Write("Choose: ");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                Console.WriteLine("The Total is: ");
                                Console.Write(value1 + value2);
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number input.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number input.");
                        }
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                Console.WriteLine("The Difference is: ");
                                Console.Write(value1 - value2);
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number input.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number input.");
                        }
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                Console.WriteLine("The Total is: ");
                                Console.Write(value1 * value2);
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number input.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number input.");
                        }
                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                Console.WriteLine("The Total is: ");
                                Console.Write(value1 / value2);
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number input.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid choice.");
                    }

                }
                else if(choice == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Select a choice");
                    Console.WriteLine("1. Kilometres to Miles");
                    Console.WriteLine("2. Celsius and Fahrenheit");
                    Console.WriteLine("3. GHS to USD");
                    Console.Write("Choose: ");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Enter your value in Kilometres");
                        
                        if (double.TryParse(Console.ReadLine(), out double value))
                        {
                            value *= 0.6214;
                            Console.WriteLine("The value in Miles is: ");
                            Console.Write(value);
                        } else
                        {
                            Console.WriteLine("Enter a valid number input.");
                        }
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Enter your value in Celcius");
                        if (double.TryParse(Console.ReadLine(), out double value))
                        {
                            value = (value * 1.8) + 32;
                            Console.WriteLine("The value in Fahrenheit is: ");
                            Console.Write(value);
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number input.");
                        }
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Enter your value in Ghana Cedis: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            Console.WriteLine("Enter your value for the exchange rate to USD: ");
                            if (double.TryParse(Console.ReadLine(), out double value))
                            {
                                value *= amount;
                                Console.WriteLine("The value in USD is:");
                                Console.Write(value);
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid number input.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid choice.");
                    }
                }
                else
                {
                    break;
                }
            }
            //Console.ReadKey();
        }
    }
}
