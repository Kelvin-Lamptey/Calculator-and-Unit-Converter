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
                //Show the main menu
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You are welcome to my Calcuator and Unit Converter App!!");
                Console.WriteLine("Select an option.");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Convert");
                Console.WriteLine("3. Exit");
                //Request for input
                Console.Write("Choose: ");
                choice = Console.ReadLine();
                //Check the choice and show the right sub menu
                if (choice == "1")
                {
                    //show the submenu
                    Console.WriteLine();
                    Console.WriteLine("Select a choice");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Substract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("3. Divide");
                    //Request for input
                    Console.Write("Choose: ");
                    choice = Console.ReadLine();
                    //Check the choice and show the right sub menu
                    if (choice == "1")
                    {
                        //Request for values and convert to numbers and flag as invalid when it is not valid
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                //compute the solution and print to screen
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
                        //Request for values and convert to numbers and flag as invalid when it is not valid
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                //compute the solution and print to screen
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
                        //Request for values and convert to numbers and flag as invalid when it is not valid
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                //compute the solution and print to screen
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
                        //Request for values and convert to numbers and flag as invalid when it is not valid
                        Console.WriteLine("Enter your first value");
                        if (double.TryParse(Console.ReadLine(), out double value1))
                        {
                            Console.WriteLine("Enter your second value");
                            if (double.TryParse(Console.ReadLine(), out double value2))
                            {
                                //compute the solution and print to screen
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
                    //Request for values and convert to numbers and flag as invalid when it is not valid
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
                            //compute the solution and print to screen
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
                        //Request for values and convert to numbers and flag as invalid when it is not valid
                        Console.WriteLine("Enter your value in Celcius");
                        if (double.TryParse(Console.ReadLine(), out double value))
                        {
                            //compute the solution and print to screen
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
                        //Request for values and convert to numbers and flag as invalid when it is not valid
                        Console.WriteLine("Enter your value in Ghana Cedis: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            Console.WriteLine("Enter your value for the exchange rate to USD: ");
                            if (double.TryParse(Console.ReadLine(), out double value))
                            {
                                //compute the solution and print to screen
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
