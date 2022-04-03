/*Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/



void PozitivNumbers()
{
    int count = 0;
    Console.Write("Enter quantity of numbers: ");
    int M = Convert.ToInt32(Console.ReadLine());


    for (int i = 1; i <= M; i++)
    {
        Console.Write($"Enter number {i}: ");
        int num = Convert.ToInt32(Console.ReadLine());


        if (num > 0) count++;

    }
    if (count == 0) Console.WriteLine("You didn't enter positive numbers!");
    else
    {
        Console.WriteLine();
        Console.WriteLine("Quantity of positive numbers: " + count);

    }

}
PozitivNumbers();