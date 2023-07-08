Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < n1; i++)
if (n1 % 2 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
    