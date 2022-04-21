Console.WriteLine("Vvedite chislo strok: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine();

int[,] ar = new int[n, n * 2];

int b = n - 1;
int c = n - 1;
int d = n - 1;
int e = n - 1;
int f = n - 1;
for (int i = 0; i < ar.GetLength(0); i++)
{
    for (int j = 0; j < ar.GetLength(1); j++)
    {

        ar[i, j] = 0;

        if (j == b) ar[i, j] = 1;
        if (j == c) ar[i, j] = 1;

    }
    b--;
    c++;

}


for (int i = 2; i < ar.GetLength(0); i++)
{
    int count = (d - i) + 2;
    for (int j = 0; j < ar.GetLength(1); j++)
    {

        if (j == count && j < d + i)
        {

            ar[i, j] = ar[i - 1, j - 1] + ar[i - 1, j + 1];
            count = count + 2;
        }


    }



}


void PascalTriangle(int[,] ar)
{
    string[,] ar2 = new string[n, n * 2];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar2[i, j] = Convert.ToString(ar[i, j]);

            if (Convert.ToString(ar[i, j]) == "0")
            {
                ar2[i, j] = " ";
            }

            if (Convert.ToString(ar[i, j]) != "0" && Convert.ToString(ar[i, j]).Length < 2)
            {
                ar2[i, j] = " " + Convert.ToString(ar[i, j]);
            }


            Console.Write(ar2[i, j]);
        }
        Console.WriteLine();
    }
}

PascalTriangle(ar);