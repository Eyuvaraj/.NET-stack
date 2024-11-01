using System;
using System.Collections.Generic;

namespace dotNet_Learnings{
    class ReverseList{
        static void Main(string[] args){
            Console.Write("Enter a list of characters seperated by comma: ");
            string input_str = Console.ReadLine();
            string[] L = input_str.Split(',');

            Console.Write("Reversed List: ");


            for (int i=L.Length-1; i>=0; i--){
                Console.Write($"{L[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}