using System;

namespace dotNet_Learnings
{
    class Palindrome
    {
        static bool IsPalindrome(string k)
        {
            string reverse_k = "";
            // Loop through the string in reverse to build the reversed string
            for (int i = k.Length - 1; i >= 0; i--)
            {
                reverse_k += k[i];
            }
            return k.ToLower() == reverse_k.ToLower();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string k = Console.ReadLine();
            if (IsPalindrome(k))
            {
                Console.WriteLine($"\"{k}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{k}\" is not a palindrome.");
            }
        }
    }
}
