// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitalSum (int a)
{
    int sum = 0;

   
    while ( a > 0 )
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}


Console.WriteLine("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

int result = DigitalSum (number);

Console.WriteLine("Сумма цифр равна "+ result);
