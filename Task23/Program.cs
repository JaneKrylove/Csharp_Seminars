// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cube (int n1)
{
    for(int i = 1; i <= n1; i++)
    {
        Console.Write(i*i*i + " ");
    }
}
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

cube (n1);
