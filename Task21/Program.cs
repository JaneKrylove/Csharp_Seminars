// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double space (double x1,double y1, double z1,double x2, double y2, double z2)
{
    double gipotenuza = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return gipotenuza;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Правильный ответ: " + space (x1,y1,z1,x2,y2,z2));