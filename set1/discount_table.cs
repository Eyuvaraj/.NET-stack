using System;
using System.Collections.Generic;

namespace dotNet_Learnings{
    class discount_table
    {
        public static string Discount(double k)
        {
            double discounted_price = k - (0.60 * k);
            return $"Original price: ${k}, Discounted_price: ${discounted_price}, Your Savings: ${k-discounted_price}";
        }
        static void Main(string[] args){
            List<double> prices = new List<double> { 4.95, 9.95, 14.95, 19.95, 24.95 };  // Added semicolon here
            foreach (double k in prices){
                Console.WriteLine(Discount(k));
            }
        }
    }
}