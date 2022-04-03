/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;*/

void SrArifmMasiv()
{

    int[,] ar = new int[3, 4];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            ar[i, j] = new Random().Next(10);
            Console.Write(ar[i, j] + " ");
        }
        Console.WriteLine();
    }

    for (int j = 0; j < 4; j++)
    {
        double a = 0;
        for (int i = 0; i < 3; i++)
        {
            a = a + ar[i, j];
            
        }
        if (j < 3) Console.Write(Math.Round((a/3),1) + "; ");
        else Console.Write(Math.Round((a/3),1) + ". ");
    }
}

SrArifmMasiv();