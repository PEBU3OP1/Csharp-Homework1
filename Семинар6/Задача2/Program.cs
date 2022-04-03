/*Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

3, 4 ->
1 1 1 1
1 0 0 1
1 1 1 1
*/


void DoubleArray()
{
    Console.Write("Enter q-ty of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter q-ty of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());


    int [,] ar = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(i == 0 || i == rows-1) ar[i,j] = 1;
            else if (j == 0 || j == columns-1) ar[i,j] = 1; 
            else ar[i,j] = 0;
            Console.Write(ar[i,j] + " ");
        }
        Console.WriteLine();
    }

}

DoubleArray();