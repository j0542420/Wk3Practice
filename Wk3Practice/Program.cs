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

            //while loop
            // loop to keep asking user a input a string
            // check if user input QUIT, set the condition to false
            // else, convert it to number and proccess print all odd number less than

            //declerations

            //input
            string userInput = "";
            int number = 0;
            bool continueToRun = true;

             while (continueToRun) {

                Console.WriteLine("Input a number or type QUIT to exit");\
                userInput = Console.ReadLine(); // take in the input
                //ToLower() converters all th echaracters to lower case
                //Startwith check if the string with a certain character/string

                if (userInput.ToLower().StartsWith("q"))
                {
                    //check if user input QUIT, set the continue to false
                    continueToRun = false;
                }
                else 
                {
                    //convert it to number and proccess
                    number = Convert.ToInt32(userInput);

                    //print all od numbers less than
                    for (int i = 1; i < number; i += 2)
                    {
                        Console.WriteLine(i); 
                    }
                }




        }
    }
}
