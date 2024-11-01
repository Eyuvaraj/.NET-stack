using System;


namespace dotNet_Learnings{
    class PrimeNumbers{
        static void Main(string[] args){
            Console.Write("Enter a start Range: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a End Range: ");
            int b = int.Parse(Console.ReadLine());

            if (b - a > 2){
                Console.WriteLine($"Prime Numbers in range {a}-{b}: ");
                for (int i = Math.Max(2, a); i <= b; i++){
                    bool isPrime = true;
                    for (int j = 2; j * j <= i; j++){ 
                        if (i % j == 0){
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime){
                        Console.Write($"{i} ");
                    }
                }
            }
            else{
                Console.WriteLine("Enter a Valid Range");
            }
            Console.WriteLine("\n");
        }
    }
}