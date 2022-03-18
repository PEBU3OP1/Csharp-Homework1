 void SecondNum(int num){
 
   

if (num > 0 && num < 100){

    Console.Write("Число не 3 значное!!!");
   
}

else if (num > 100 && num < 1000){

    int n1 = Math.Abs(num % 100);
    int n2 = Math.Abs(n1 / 10);
    Console.Write("Вторая цифра введенного числа: " + n2);
   
}

else if (num > 1000 && num < 10000){

    int n1 = Math.Abs(num % 1000);
    int n2 = Math.Abs(n1 / 100);
    Console.Write("Вторая цифра введенного числа: " + n2);
   
}

else if (num > 10000 && num < 100000){

    int n1 = Math.Abs(num % 10000);
    int n2 = Math.Abs(n1 / 1000);
    Console.Write("Вторая цифра введенного числа: " + n2);
   
}
else{
    Console.Write("Мне это надоело! Проще через массив");
        
}
   
}

Console.WriteLine("Введите 3 значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
SecondNum(num);    
