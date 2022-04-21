




int[] ArrFilling(int length, int width, int height)
{
    int[] arr = new int[length*width*height];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(10, 100);

    }
    return arr;
    
}


int[] CheckingUnique(int[] arr)
{
    while (true)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (arr[i] == arr[j])
                {
                    arr[i] = new Random().Next(10, 100);
                }

            }

        }

        break;
    }

    return arr;
}


void Print3DArr(int length, int width, int height, int[] arr)
{
    int[,,] ar = new int[length, width, height];
    int a = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            for (int z = 0; z < ar.GetLength(2); z++)
            {

                ar[i, j, z] = arr[a];
                a++;
                Console.Write($" {ar[i, j, z]}{(i, j, z)}");
            }
            Console.WriteLine();
        }

    }
}

Print3DArr(2, 2, 2, CheckingUnique(ArrFilling(2,2,2)));