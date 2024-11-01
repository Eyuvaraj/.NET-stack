/*
Fibonacci Sequence

Write a program that reads an integer n from the user and prints the first n terms of the Fibonacci sequence. Use a loop to generate the sequence.

------- code below----------*/

using System;

namespace dotNet_Learnings{
    class Fibonacci{
        static void Main(string[] args){
            Console.Write("\nEnter Length of series to be generated: ");
            string k = Console.ReadLine();
            int len = int.Parse(k);
            Console.WriteLine($"\nFibonnacci Series of length {len}: ");
            int[] FibArr = new int[len];

            FibArr[0] = 0;
            FibArr[1] = 1;
            FibArr[2] = 1;

            for (int i = 3; i<=len-1; i++){
                FibArr[i] = FibArr[i-1] + FibArr[i-2];
            }

            for (int i=0; i<=len-1; i++){
                Console.Write($"{FibArr[i]} ");
            }
            Console.WriteLine("\n");

        }
    }
}