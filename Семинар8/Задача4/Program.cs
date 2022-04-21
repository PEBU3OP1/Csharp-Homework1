/*Задача 4: Заполните спирально массив 4 на 4.

На выходе получается вот такой массив:

1   2 3  4
12 13 14 5
11 16 15 6
10  9  8 7
*/

int[,] FillingArr(int row, int column)
{
    int[,] ar = new int[row, column];

    for (int i = 0; i < 4; i++)
    {
        ar[0, i] = i + 1;
    }

    for (int i = 1; i < 4; i++)
    {
        ar[i, 3] = i + 4;
    }

    int a = 8;
    for (int i = 2; i > -1; i--)
    {

        ar[3, i] = a;
        a++;
    }

    int b = 11;
    for (int i = 2; i > 0; i--)
    {

        ar[i, 0] = b;
        b++;
    }

    for (int i = 1; i < 3; i++)
    {
        ar[1, i] = i + 12;
    }


    int c = 15;
    for (int i = 1; i < 3; i++)
    {

        ar[2, i] = i + c;
        c = c - 2;
    }
    return ar;
}


void PrintArr (int [,] ar){
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(ar[i, j] + " ");
    }
    Console.WriteLine();
}
}
PrintArr(FillingArr(4,4));