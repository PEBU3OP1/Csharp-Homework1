/*Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

void RaznitsamaxMin()
{
    int[] ar = new int[4];
    int min = 0;
    int max = 0;
    
    Console.Write("Наш массив: ");
    for (int i = 0; i < 4; i++)
    {

        ar[i] = new Random().Next(10, 100);
        Console.Write(ar[i] + " ");
        if (i == 0)
        {
        min = ar[0];
        max = ar[0];
        }

        if (max < ar[i]) max = ar[i];
        else if (min > ar[i]) min = ar[i];
    }

    int razn = max - min;
    Console.WriteLine();
    Console.WriteLine("MAX: " + max);
    Console.WriteLine("MIN: " + min);
    Console.WriteLine();
    Console.WriteLine("Разница: " + razn);
}
RaznitsamaxMin();