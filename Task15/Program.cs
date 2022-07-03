Console.WriteLine("Введите число: ");

string number = Console.ReadLine();

if (number != null) FindWeekdDay (number);


void FindWeekdDay(String day)
    
{   
    int n1 = Convert.ToInt32(day);
    if (n1 <=0 || n1>7)
        Console.WriteLine ("Are you crazy?");
    else if (n1>5 && n1<=7)
        Console.WriteLine ("Ура, это выходной!");

    else Console.WriteLine ("Рабочий день");
}

    