// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 24;
int e = 26;

Console.WriteLine($"a is {a}, e is {e}");

if (a < e){
    Console.WriteLine("a is less than e");
} else {
    Console.WriteLine("a is greater than e");
}

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine($"Hi, {name}!");

Console.WriteLine("Enter you age: ");
string age_ = Console.ReadLine();
int age = Convert.ToInt32(age_);


Console.WriteLine($"Vijay Gunda");