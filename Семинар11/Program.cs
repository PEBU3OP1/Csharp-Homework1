


int[] FillingInfo(int qty)
{
    int[] info = new int[qty];


    for (int i = 0; i < info.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} член массива info");
        info[i] = Convert.ToInt32(Console.ReadLine());

    }
    return info;

}

void PrintInfo(int[] info)
{
    Console.Write("Массив info: ");
    for (int i = 0; i < info.Length; i++)
    {
        Console.Write(info[i] + " ");
    }
}

int SchetDlinData(int[] info)
{
    int sum = 0;
    for (int i = 0; i < info.Length; i++)
    {
        sum = sum + info[i];
    }
    return sum;
}

int[] FillingData(int sum)
{
    int[] data = new int[sum];
    for (int i = 0; i < data.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} член массива data");
        data[i] = Convert.ToInt32(Console.ReadLine());
        while (data[i] > 1 || data[i] < 0)
        {
            Console.WriteLine("Значение должно быть либо 1, либо 0!!!");
            Console.WriteLine($"Введите {i + 1} член массива data");
            data[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return data;
}


void PrintData(int[] data)
{
    Console.Write("Массив data: ");
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write(data[i] + " ");
    }
}

void Rezultat(int[] info, int[] data)
{
    int[] ar = new int[info.Length];
    int SchetNizh = 0;
    int SChetVerh = 0;

    Console.WriteLine("Вот Ваш результат: ");

    for (int i = 0; i < info.Length; i++)
    {
        double rezultat = 0;
        double stepen = info[i] - 1;
        SChetVerh = SChetVerh + info[i];

        for (int j = SchetNizh; j < SChetVerh; j++)
        {
            rezultat = rezultat + (data[j] * Math.Pow(2, stepen));
            stepen--;
        }
        SchetNizh = SchetNizh + info[i];

        ar[i] = Convert.ToInt32(rezultat);
        Console.Write(ar[i] + " ");
    }
}

Console.WriteLine("Какое кол-во чисел шифруем?");
int qty = Convert.ToInt32(Console.ReadLine());

int[] info = FillingInfo(qty);
PrintInfo(info);

int summa = SchetDlinData(info);

Console.WriteLine();
Console.WriteLine();

int[] data = FillingData(summa);
PrintData(data);

Console.WriteLine();
Console.WriteLine();

Rezultat (info, data);