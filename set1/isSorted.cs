/***<u>Exercise 4: Sorted Order**</u>

Write a program that reads integers from the user and stores them in a list. Your
program should continue reading values until the user enters 0. Then it should display
all of the values entered by the user (except for the 0) in ascending order, with one
value appearing on each line. Use either the sort method or the sorted function
to sort the list.

------- code below----------
*/


using System;
using System.Collections.Generic;

namespace dotNet_Learnings
{
    class isSorted{
        static bool Sorted(double[] k){
            int len_k = k.Length;
            if (len_k == 1){
                return true;
            }
            if (k[0]>k[len_k-1]){
            for (int i = 0; i < len_k - 1; i++)
                {
                    if (k[i]>=k[i+1]){
                        continue;
                    }
                    else{
                        return false;
                    }
                }
            } else {
                for (int i = 0; i < len_k -1; i++){
                    if (k[i]<=k[i+1]){
                        continue;
                    }
                    else{
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args){
            Console.WriteLine("Enter a list of integers seperated by comma: ");
            string k = Console.ReadLine();
            string[] l = k.Split(',');
            double[] n = new double[l.Length];

            for (int i=0; i<l.Length; i++){
                n[i]=double.Parse(l[i]);
            }
            Console.WriteLine($"is Sorted? {Sorted(n)}");
        }
    }
}