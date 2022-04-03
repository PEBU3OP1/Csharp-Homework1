/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;


while (true)
{
    int a = num % 10;
    sum = sum + a;
    num = num / 10;

    if (num / 10 == 0)
    {
        sum = sum + num;
        break;
    }
}


Console.WriteLine("Сумма с помощью деления и остатков: " + Math.Abs(sum));





void Main()
{
    Console.Write("Введите число: ");
    string num = Console.ReadLine();



    char[] ar = num.ToCharArray();
    int sum = 0;

    if (num[0] == 45)
    {
        for (int i = 1; i < ar.Length; i++)
        {
            int b = Convert.ToInt32(Convert.ToString(ar[i]));
            sum = sum + b;
        }
        Console.WriteLine("Сумма через массив: " + sum);
    }
    else
    {
        for (int i = 0; i < ar.Length; i++)
        {
            int b = Convert.ToInt32(Convert.ToString(ar[i]));
            sum = sum + b;
        }
        Console.WriteLine("Сумма через массив: " + sum);
    }
}

Main();
