using System;
using System.Collections.Generic;

namespace dotNet_Learnings
{
    class UniqueElements
    {
        static void Main(string[] args)
        {
            string k;
            List<double> arr = new List<double>();

            Console.WriteLine("Enter a series of numbers (press Enter on an empty line to stop): ");

            do
            {
                Console.Write("\nEnter a number: ");
                k = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(k)) // Only add non-blank input
                {
                    if (double.TryParse(k, out double number)) // Validate input as a number
                    {
                        arr.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            } while (!string.IsNullOrWhiteSpace(k)); // Exit if blank line is entered

            // Use HashSet to remove duplicates, then sort the result
            HashSet<double> uniqueArr = new HashSet<double>(arr);
            List<double> sortedUniqueArr = new List<double>(uniqueArr);
            sortedUniqueArr.Sort();

            Console.WriteLine("\nUnique elements in ascending order:");
            foreach (double i in sortedUniqueArr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
