// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstName = "   Eyuvaraj  ";
string lastName = "   D   ";
Console.WriteLine($"Hi, this is {firstName.Trim()} {lastName.TrimStart()}");

lastName = lastName.Trim();

Console.WriteLine(lastName.Replace("D", "Dev"));

Console.WriteLine(lastName.ToUpper());