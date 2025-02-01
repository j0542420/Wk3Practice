using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 0; i < 100; i = i + 2)
            {
                Console.WriteLine(i);
            }

            // Declarations
            string userInput = "";
            int number = 0;
            bool continueToRun = true;

            // While loop to keep asking the user for input
            while (continueToRun)
            {
                Console.WriteLine("Input a number or type QUIT to exit:");
                userInput = Console.ReadLine(); // Take in the input

                // ToLower() converts all characters to lower case
                // StartsWith() checks if the string starts with a certain character/string
                if (userInput.ToLower().StartsWith("q"))
                {
                    // Check if user input is "QUIT" (or starts with 'q') and stop the loop
                    continueToRun = false;
                }
                else
                {
                    // Try to convert the input to a number and process
                    if (int.TryParse(userInput, out number))
                    {
                        // Print all odd numbers less than the given number
                        Console.WriteLine($"Odd numbers less than {number}:");
                        for (int i = 1; i < number; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number or type QUIT to exit.");
                    }
                }
            }
        }
    }
}