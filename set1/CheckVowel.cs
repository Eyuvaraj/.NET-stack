using System;
using System.Collections.Generic;

namespace dotNet_Learnings
{
    class CheckVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter: ");
            string letter = Console.ReadLine();
            letter = letter.ToLower();

            Console.WriteLine($"You entered: {letter}");

            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };

            if (vowels.Contains(letter))
            {
                Console.WriteLine($"{letter} is a vowel!");
            }
            else
            {
                Console.WriteLine($"{letter} is not a vowel!");
            }
        }
    }
}