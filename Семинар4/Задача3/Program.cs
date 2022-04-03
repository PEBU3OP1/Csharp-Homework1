
/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void NewMasive ()
{
    string [] ar = new string [8];
    for (int i = 0; i < ar.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} член массива: ");
        ar[i] = Console.ReadLine();

    }
    Console.WriteLine();
    Console.WriteLine("Вот Ваш массив: ");
    foreach(string s in ar) Console.Write(s +" ");
}

NewMasive();