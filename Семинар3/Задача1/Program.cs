void polindrom(int chislo){

    int DesTys = chislo / 10000;
    int Tys = (chislo - DesTys * 10000)/1000;
    
    int Des = (chislo % 100) / 10;
    int Ed = (chislo % 100) % 10;
    
    if (DesTys >= 10 | DesTys == 0)
    {
        Console.WriteLine("Число должно быть 5 значным!!!");
        
    }
    
    
    else if (DesTys == Ed && Tys == Des)
    {
        Console.WriteLine("Да, число " + chislo + " - полиндром");
    }

    else
    {
        Console.WriteLine("Нет, число " + chislo + " - не полиндром");
    }


}





void PolindromByArray (int chislo){

    char [] arr = chislo.ToString().ToCharArray();

    if (arr.Length != 5){
        Console.WriteLine("Через Массив: Число должно быть 5 значным!!!");
    }
    
    else if (arr[0] == arr[4] && arr[1] == arr[3]){
        Console.WriteLine("Через Массив: Да, число " + chislo + " - полиндром");
    }

    else
    {
        Console.WriteLine("Через Массив: Нет, число " + chislo + " - не полиндром");
    }

}

Console.WriteLine("Введите число для проверки: ");
int chislo =  Math.Abs(Convert.ToInt32(Console.ReadLine()));

polindrom(chislo);
PolindromByArray(chislo);