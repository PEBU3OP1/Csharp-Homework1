int [,] ZadayuArr (int row, int column)
{
    Console.WriteLine("Исходный массив: ");
    int [,] ar = new int [row, column];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar [i, j] = new Random().Next(10);
            Console.Write(ar[i,j] + " ");
            
        }
    Console.WriteLine();
    }
    return ar;
}



int [,] Raspredelenie (int [,] ar)
{
    int temp;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            for (int k = 0; k < ar.GetLength(1); k++)
            {
                if (ar[i,j] < ar[i,k])
                {
                    temp = ar[i,j];
                    ar[i,j] = ar[i,k];
                    ar[i,k] = temp;
                }
            }
            
        }
        
    }
    return ar;
}


void PrintAr(int [,]ar)
{
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив: ");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(ar[i,j] + " ");
            
        }
    Console.WriteLine();
    }
}


int[,] arr = ZadayuArr (3,4);
PrintAr(Raspredelenie(arr));


