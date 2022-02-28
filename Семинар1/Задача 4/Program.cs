
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine("Числа четные через while: ");

while (i <= N)
{
    if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
i = i+1;
}
Console.WriteLine("");
Console.WriteLine("Числа четные через for: ");
for (int a = 1; a <= N; a++)
{
    if(a % 2 == 0)
    {
        Console.Write(a + " ");
    }
}
