/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

void SchetChetnyh()
{
    int[] ar = new int[8];
    int schet = 0;

    Console.Write("Наш массив: ");
    for (int i = 0; i < 8; i++)
    {
        ar[i] = new Random().Next(100, 1000);
        if (ar[i] % 2 == 0) schet++;
        Console.Write(ar[i] + " ");
    }
     Console.WriteLine();
    Console.WriteLine("Количество четных членов: " + schet);
}

SchetChetnyh();