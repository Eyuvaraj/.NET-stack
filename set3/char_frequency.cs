/*Character Frequency

Write a program that reads a string from the user and counts the frequency of each character in the string and display the character frequencies.

*/

using System;
using System.Collections.Generic;

namespace dotNet_Learnings{
    class CharFrequency{
        static void Main(string[] args){
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            Dictionary<char, int> CharCount = new Dictionary<char, int>();

            for (int i=0; i<input.Length; i++){
                if (CharCount.ContainsKey(input[i])==true){
                    CharCount[input[i]]+=1;
                } else {
                    CharCount[input[i]]=1;
                }
            }

            Console.WriteLine("CHARACTER FREQUENCY: \n");
            Console.WriteLine("  c | Count");
            Console.WriteLine("  ---------");

            foreach (KeyValuePair<char, int> KV in CharCount){
                Console.WriteLine($" {KV.Key} | {KV.Value}");
            }
        }
    }
}