using System;

namespace Conditionals_Sakiestewa_Santino
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for whole number and ssigns to ionteger variable
            Console.WriteLine("Enter a whole number, please!");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // Checks if positive or negative
            if (myWholeNum == 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number!");
            }

            // Checks if even or odd
            if (myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is an odd number!");
            }

            //Creates two more integer numbers
            int num1 = 6;
            int num2 = 99;

            //Gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            //Gets maximum number
            int max = Math.Max(firstMax, num2);

            //Prints max to console
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is { max }!");
        
                
        }
    }
}
