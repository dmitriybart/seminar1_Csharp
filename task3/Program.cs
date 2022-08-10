Console.Write("Введите конечное число: ");
int n = int.Parse (Console.ReadLine());
int i = 1;
while (i < n+1)
{
    if(i%2==0)
    {
        Console.Write(i + " ");
    }
    i++;
}