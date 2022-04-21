/*Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] NewArr(int row, int column)
{
    int[,] ar = new int[row, column];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i, j] = new Random().Next(5);
            Console.Write($"{ar[i, j]} ");
        }
        Console.WriteLine();
    }
    return ar;
}

void PoiskSumm(int[,] ar)
{
    int s1 = 0, s2 = 0, a = 0;

    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (i == 0) s1 = s1 + ar[0, j];
            if (i > 0)
            {
                s2 = s2 + ar[i, j];
            }

        }

        if (s2 > s1)
        {
            s1 = s2;
            s2 = 0;
            a = i;
        }
        else s2 = 0;


    }

    Console.WriteLine($"Максимальная сумма элементов в строчке номер {a}");
}
PoiskSumm(NewArr(4, 3));