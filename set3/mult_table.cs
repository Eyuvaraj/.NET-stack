using System;

namespace dotNet_Learnings{
    class MultiplicationTable{
        static void Main(string[] args){
            Console.Write("Enter a Number to generate a Multiplication table: ");
            string s = Console.ReadLine();

            int k = int.Parse(s);

            for (int i=1; i<=10; i++){
                Console.WriteLine($"{k} x {i} = {k*i}");
            }
        }
    }
}