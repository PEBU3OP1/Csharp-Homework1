
int min = 0;
int min1 = 0;
int max = 0;
int max1 = 0;

void method ( int chislo)
{
        if (min == 0)
            {
                min = chislo;                       // В этот цикл зайдем один раз, не хватает инструментария сделать по-другому
            }

        if (max == 0)
            {
                max = chislo;                      // В этот цикл зайдем один раз, не хватает инструментария сделать по-другому
            }


        if (min1 == 0)
            {
                min1 = chislo;                       // В этот цикл зайдем один раз, не хватает инструментария сделать по-другому
            }

        if (max1 == 0)
            {
                max1 = chislo;                      // В этот цикл зайдем один раз, не хватает инструментария сделать по-другому
            }



        


        int a = min;

        if (chislo < min)
        {
                
            min = chislo;       
            if(min1 >= a)
            {
              min1 = a;
            }
        }


        if (min1 == min)
        {
            min1 = chislo;
        }
        
         if (chislo > min)
        {                        
            if(min1 >= chislo && chislo >= a)
                {
                min1 = chislo;
                }
        }
               
        


        

        int b = max;

        if (chislo > max)
        {             
            max = chislo;
                     
            if( max1 <= b)
           {
             max1 = b;
           }
        }

        if (max1 == max){

            max1 = chislo;
        }

        if (chislo < max)
        {
            if(max1 <= chislo && chislo <= b)
                {
                max1 = chislo;
                }
        }


}





while(true){

Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

if (chislo == 0){
    break;
}

else{
method(chislo);
}

Console.WriteLine("min ravno: "+ min);
Console.WriteLine("min1 ravno: "+ min1);
Console.WriteLine("max ravno: "+ max);
Console.WriteLine("max1 ravno: "+ max1);

}
