
double Rasst3D (double xA, double yA, double zA, double xB, double yB, double zB){


    double Rasst = Math.Round(Math.Sqrt(Math.Pow(xA-xB, 2)+Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2)), 2);
    return Rasst;
}




Console.WriteLine("Введите координаты A по X: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты A по Y: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты A по Z: ");
double zA = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите координаты B по X: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты B по Y: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты B по Z: ");
double zB = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Расстояние от A до B: " + Rasst3D (xA, yA, zA, xB, yB, zB));