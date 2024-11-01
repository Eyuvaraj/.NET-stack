/*Grade Distribution

Write a program that reads grades from the user until a blank line is entered. The program should then display the number of grades in each grade range (e.g., A, B, C, D, F) according to the standard grading scale (90-100, 80-89, etc.).

# ------- code below----------*/


using System;
using System.Collections.Generic;

namespace dotNet_Learnings{
    class grade_dist{
    static char GetGrade(int Mark){
        if (Mark >= 91 && Mark <=100){
            return 'A';
        } else if (Mark >= 81 && Mark <= 90){
            return 'B';
        } else if (Mark >= 71 && Mark <= 80){
            return 'C';
        } else if (Mark >= 61 && Mark <= 70){
            return 'D';
        } else if (Mark >= 51 && Mark <= 60){
            return 'E';
        } else {
            return 'F';
        }
    }
        static void Main(string[] args){
            Console.WriteLine("ENTER MARKS FOR THE SUBJECTS: ");
            List<int> Marks = new List<int>();

            string tempMark;

            int idx = 0;

            do{
                idx+=1;
                Console.Write($"Enter Marks for Subject-{idx}: ");
                tempMark = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(tempMark)){
                    Marks.Add(int.Parse(tempMark));
                } else {
                    Console.WriteLine();
                }
            } while (!string.IsNullOrWhiteSpace(tempMark));


            Dictionary<char, int> GradeDist = new Dictionary<char, int>();

            for (int i=0; i<=Marks.Count-1; i++){
                // Console.WriteLine($"Subject-{i+1} Grade:  {GetGrade(Marks[i])}");
                char Grade = GetGrade(Marks[i]);

                if (GradeDist.ContainsKey(Grade)==true){
                    GradeDist[Grade]+=1;
                } else {
                    GradeDist[Grade]=1;
                }
            }

            Console.WriteLine("GRADE DISTRIBUTION: \n");
            Console.WriteLine("  G | Count");
            Console.WriteLine("  ---------");

            foreach(KeyValuePair<char, int> KV in GradeDist){
                Console.WriteLine($"> {KV.Key} | {KV.Value}");
            }
        }
    }
}