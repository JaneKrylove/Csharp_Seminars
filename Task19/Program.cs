// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrom (int a)
{
    if(a/10000 == a % 10)
        {
            if(a / 1000 % 10 == a % 100 / 100);
            return true;
        }

        else 

        return false;

}
            
    
Console.WriteLine("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Palindrom (number));
        
    
    
     