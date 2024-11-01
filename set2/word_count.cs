/*Word Count

Write a program that reads a sentence from the user and counts the number of words in the sentence. 

# ------- code below----------*/


using System;
using System.Collections.Generic;


namespace dotNet_Learnings{
    class word_count{
        static void Main(string[] args){
            Console.Write("> Enter a sentence: ");
            string inputSentence = Console.ReadLine();

            string[] words = inputSentence.Split(" ");
            Console.WriteLine($"\n> Word Count: {words.Length}");
        }
    }
}