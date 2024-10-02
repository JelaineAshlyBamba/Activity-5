using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Prompt the user for an integer input
            Console.Write("Enter an integer: ");
            
            // Step 2: Read and parse the input
            string input = Console.ReadLine();
            int number;

            // Check if the input is a valid integer
            if (int.TryParse(input, out number))
            {
                // Step 3: Print the multiplication table using a for loop
                Console.WriteLine($"Multiplication Table for {number}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
