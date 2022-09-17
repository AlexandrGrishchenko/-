// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите числа");
string s = Console.ReadLine();
int a = Convert.ToInt32(s);

string s2 = Console.ReadLine();
int b = Convert.ToInt32(s2);

string s3 = Console.ReadLine();
int c = Convert.ToInt32(s3);

string s4 = Console.ReadLine();
int d = Convert.ToInt32(s4);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("Максимальное число, ");
Console.Write(max);