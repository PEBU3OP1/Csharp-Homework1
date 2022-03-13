void ThirdDigitByArray (int num){


    char[] arr = num.ToString().ToCharArray();
    if (arr.Length < 3)
    {
    Console.WriteLine("третьей цифры нет");
    }


    else
    {
    Console.WriteLine("Третья цифра: " + arr[2]);
    }
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdDigitByArray(num);