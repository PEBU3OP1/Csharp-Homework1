
Console.WriteLine("Введите чило a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило c: ");
int c = Convert.ToInt32(Console.ReadLine());


    if(a > b && a > c)
    {
        Console.WriteLine("Результат сравнения : a больше b и c и равно");
        Console.Write(a);
    }
    if(b > a && b > c)
    {
        Console.WriteLine("Результат сравнения тройки 1: b больше a и c и равно");
        Console.Write(b);
    }
    else
    {
        Console.WriteLine("Результат сравнения тройки 1: c больше a и b и равно");
        Console.Write(c);
    }


