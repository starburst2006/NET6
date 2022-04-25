// See https://aka.ms/new-console-template for more information

int a = 10;

int b = 20;

int c = 0;
Console.WriteLine("původní a=" + a + ", původní b=" + b);

c = a;
a = b;
b = c;

Console.WriteLine("nové a=" + a + ", nové b=" + b);
