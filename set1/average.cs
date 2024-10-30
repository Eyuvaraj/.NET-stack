using System;
using System.Collections.Generic;

namespace dotNet_Learnings
{
    class average{

        static List<double> AboveAVG(List<double> l, double avg){
            List<double> AbvAVG = new List<double>();

            foreach (double i in l){
                if (i>avg){
                    List.Add()
                }
            }
        }
        static void Main(string[] args){
            Console.Write("ENTER A LENGTH OF ARRAY: ");
            string len_ = Console.ReadLine();
            int len = int.Parse(len_);

            List<double> A = new List<double>();

            double sum = 0;

            for (int i=0; i<=len-1; i++){
                Console.Write($"ENTER {i+1}th ELEMENT: ");
                string k = Console.ReadLine();
                A.Add(double.Parse(k));

                sum += double.Parse(k);
            }

            double average = sum/len;

            Console.WriteLine($"\n\nAVERAGE: {average}");
        }
    }
}