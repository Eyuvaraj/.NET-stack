/***Celsius to Fahrenheit Table

Create a program that generates a table converting temperatures from Celsius to Fahrenheit. The table should show conversions from 0°C to 100°C in increments of 10°C.

F = (1.8*C) + 32

# ------- code below----------*/


using System;

 namespace dotNet_Learnings{
    class Fahrenheit{
        static void Main(string[] args){
            Console.WriteLine("Celsius to Fahrenheit table: \n");

            for (int i=0; i<=100;){
                Console.WriteLine($"> {i} C = {(1.8*i)+32} F");
                i=i+10;
            }
        }
    }
 }