/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет*/

void AdresChlenaMasiva ()
{
    int [,] ar = new int [3,4];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            ar[i,j] = new Random().Next(10);
            Console.Write(ar[i,j] + " ");
        }
    Console.WriteLine();
    }

    Console.Write("Enter row number: ");
    int row = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    Console.Write("Enter column number: ");
    int column = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (row > 2 || column > 3)
    {
        Console.WriteLine("Values out of range!!");
    }
    else Console.WriteLine("Here is entered array member: " + ar[row, column]);
}
AdresChlenaMasiva();