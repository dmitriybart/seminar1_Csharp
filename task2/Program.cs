Console.Write("Введите первое число: ");
double x = double.Parse(Console.ReadLine());
Console.Write("ВВедите второе число: ");
double y = double.Parse(Console.ReadLine());
if (x > y)
{
    Console.Write("max= ");
    Console.WriteLine(x);
    Console.Write("min= ");
    Console.WriteLine(y);
}
else 
{
    Console.Write("max= ");
    Console.WriteLine(y);
    Console.Write("min= ");
    Console.WriteLine(x);
}