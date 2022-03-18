void KubCherezFor (int chislo)
{
   if (chislo > 0)
   {
        for (int i = 1; i <= chislo; i++ )
        {
            double kub = Math.Pow (i, 3);
            Console.WriteLine($"Значение через for  {i} --- куб {kub}");     
        }
   }

   if (chislo < 0)
   {
        for (int i = -1; i >= chislo; i-- )
        {
            double kub = Math.Pow (i, 3);
            Console.WriteLine($"Значение через for  {i} --- куб {kub}");     
        }
   }

    if (chislo == 0)
   {
        Console.WriteLine($"Значение через for  0 --- куб 0");   
   }

}

void KubCherezWhile (int chislo)
{
    
    
    if (chislo > 0)
   {
        int i = 1;
        while (i <= chislo)
        {
            double kub = Math.Pow (i, 3);
            Console.WriteLine($"Значение через while  {i} --- куб {kub}");   
            i++;  
        }
   }

   if (chislo < 0)
   {
        int i = -1;
        while (i >= chislo)
        {
            double kub = Math.Pow (i, 3);
            Console.WriteLine($"Значение через while  {i} --- куб {kub}");   
            i--;  
        }
   }

    if (chislo == 0)
   {
        Console.WriteLine($"Значение через while  0 --- куб 0");   
   }   
}


Console.WriteLine("Введите координаты A по Z: ");
int chislo = Convert.ToInt32(Console.ReadLine());

KubCherezFor(chislo);
KubCherezWhile(chislo);