// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
int a = new Random().Next(1, 20);

Console.Write("число А = ");
Console.Write(a);
double b = a % 2;
if ( b == 0)
    {
        Console.Write(" -число четное");
    }
    else 
    {
        Console.Write(" -число не четное");
    }