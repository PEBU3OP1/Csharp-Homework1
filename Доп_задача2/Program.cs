
int a, b, c, d;
int schet = 1;

int max = 0;
int max1 = 0;
int min = 0;
int min1 = 0;


void method (int chislo, int schet)
{
        

        if (chislo == 0 && schet <= 2)
        {
            Console.WriteLine("Слишком мало данных!!");
        }   
    
        
        if (schet == 1 && chislo != 0)
        {               
            min = chislo;
            max = chislo;
        }
        if (schet == 2 && chislo != 0)
        {               
           min1 = chislo;
           max1 = chislo;
           if (min1 < min)
            {
                a = min;
                min = min1;
                min1 = a;
            }
            if (max1 > max)
            {
                c = max;
                max = max1;
                max1 = c;
            }

        }
        
        if (schet > 2 && chislo != 0)
        {               
            if (chislo < min)
            {
                b = min;
                min = chislo;
                min1 = b;
            }
            
            else if (chislo > min)
            {
                if (chislo < min1)
                {
                    min1 = chislo;
                }
            }
            
            else if (chislo == min)
            {
                 min1 = chislo;
            }
        

            if (chislo > max)
            {
                d = max;
                max = chislo;
                max1 = d;
            }
            
            else if (chislo < max)
            {
                if (chislo > max1)
                {
                    max1 = chislo;
                }
            }
            
            else if (chislo == max)
            {
                 max1 = chislo;
            }
            
        }    
    

}




while(true)
{
   
    Console.WriteLine("Введите число: ");
    int chislo = Convert.ToInt32(Console.ReadLine());
    method(chislo, schet);

    if (chislo == 0)
    {
        break;   
    }

   
    

    //Console.WriteLine("min ravno: "+ min);
    //Console.WriteLine("min1 ravno: "+ min1);
    //Console.WriteLine("max ravno: "+ max);
    //Console.WriteLine("max1 ravno: "+ max1);
    schet++;
}

Console.WriteLine("min ravno: "+ min);
Console.WriteLine("min1 ravno: "+ min1);
Console.WriteLine("max ravno: "+ max);
Console.WriteLine("max1 ravno: "+ max1);




