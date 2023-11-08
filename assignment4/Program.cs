using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int number))
                {
                    if (number > 0)
                    {
                        Console.WriteLine("The number is positive.");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("The number is negative.");
                    }
                    else
                    {
                        Console.WriteLine("The number is zero.");
                    }

                    // Use the conditional operator to check if the number is even or odd
                    string parity = (number % 2 == 0) ? "even" : "odd";
                    Console.WriteLine("The number is " + parity + ".");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            
        }

    }
}

