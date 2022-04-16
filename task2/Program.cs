// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
int a = 44;
int b =5;
int c = 78;
int max = 0;
if (a>b) 
   {
        max = a;
    if (max>c)
    max = max;
    else max = c;
   }
else {max = b;
    if (max>c)
    max = max;
    else max = c;
}
Console.Write("max number = ");
Console.Write(max);
