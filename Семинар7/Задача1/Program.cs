/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void SluchDvumerMasive()
{
    double [,] ar = new double[3,4];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            ar[i,j] = Math.Round(new Random().NextDouble() * (10.0 + 10.0) - 10.0, 1);  /* это интернет труды для равномерного распределения 
                                                                                        RandomObj.NextDouble() * (end - begin) + begin */
            Console.Write(ar[i,j]+" ");
        }
    Console.WriteLine();
    }

}
SluchDvumerMasive();