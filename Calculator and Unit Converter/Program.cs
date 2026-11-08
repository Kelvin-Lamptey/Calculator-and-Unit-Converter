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
                Console.WriteLine("You are welcome to my Calcuator and Unit Converter App!!");
                Console.WriteLine("Select an option.");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Convert");
                Console.WriteLine("3. Exit");

                choice = Console.ReadLine();

                if (choice == "1")
                {

                }else if(choice == "2")
                {
                   
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
