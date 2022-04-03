/*Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


void SummaChiselNechetnyh()
{
    int [] ar = new int [8];
    int sum = 0;
    int sum1 = 0;

    Console.Write("Наш массив: ");

    for (int i = 0; i < 8; i++)
    {
        ar[i] = new Random().Next(-10, 10);
        Console.Write(ar[i] + " ");
        if (i != 0 && i % 2 == 1) sum = sum + ar[i];
              
    }
    for (int i = 1; i < 8; i +=2)
        {
            sum1 = sum1 + ar[i];
        }
    Console.WriteLine();
    Console.WriteLine("Сумма нечетных членов :" + sum);
    Console.WriteLine("Сумма нечетных членов через for:" + sum1);
}

SummaChiselNechetnyh();