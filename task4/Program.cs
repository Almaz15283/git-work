// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
int a = 1;
int i = 0;
int N = new Random().Next(3, 20);

while (i <= N)

{
    int b = i%2;
    
    if (b == 0) 
    {
        Console.Write(i);
    }
    
i++;
}
