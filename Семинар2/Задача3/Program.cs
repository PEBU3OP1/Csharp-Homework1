void Weekend (int day){
int dayoff = Math.Abs(day) % 7;

    if (dayoff == 6){
    Console.WriteLine("Да, это суббота!");

    }

    else if (dayoff == 0){
    Console.WriteLine("Да, это воскресенье!");

    }

    else {
    Console.WriteLine("Нет!");

    }

}

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

Weekend(day);