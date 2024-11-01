using System;

namespace dotNet_Learnings{
    class Factorial{
        static int Fact(int k){
            if (k<=1){
                return 1;
            } else {
                return k*Fact(k-1);
            }
        }
        static void Main(string[] args){
            Console.Write("Enter a positive Number: ");
            int k = int.Parse(Console.ReadLine());
            if (k>=0){
                Console.WriteLine($"Factorial of {k} is {Fact(k)}");
            } else {
                Console.WriteLine("Enter a valid Positive Integer!!");
            }
        }
    }
}