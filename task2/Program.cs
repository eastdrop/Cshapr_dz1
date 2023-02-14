Console.Write("Input number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else if (a < b)
{
    Console.WriteLine($"max = {b}");
}
else Console.WriteLine("Числа равны");