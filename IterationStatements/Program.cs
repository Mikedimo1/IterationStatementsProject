using System;
using System.Collections.Generic;
using System.Globalization;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();
            
            //Create a variable of type int and initialize the variable with a value of 0
            var num = 0;



            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                num++;
                // Then add your variable to "numbers"
                numbers.Add(num);

            }
            // While your variable is less than 100
            while (num < 100);


            // Create a while loop
            // While your variable is less than 200
            while (num < 200)
            {
                num++;
                // Increment your variable by 1
                numbers.Add(num);

                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");
            
            // Create a foreach loop
            foreach (var number in numbers)
            {
                // Write your variable to the console
                Console.WriteLine(number);
            }
            

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1

            for (int i = 199; i >= 0; i--)
            {
                // Write to the console "numbers" at index i

                Console.Write(numbers[i]);
                
            }
            
            

        }
    }
}
