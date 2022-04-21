int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0 }; // добавил еще 10 для проверки
int[] info = { 2, 3, 3, 1, 4 };

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