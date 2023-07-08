Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b && a > c)
    Console.Write("max: " + a);
if (b > a && b > c)
    Console.Write("max: " + b);
else
    Console.Write("max: " + c);
