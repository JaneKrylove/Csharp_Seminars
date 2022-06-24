// Задача № 4

int n1, n2, n3, max;

Console.WriteLine("Input first number: ");
n1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
n2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
n3=Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
   max = n1;
}
else
   max = n2;

if (max > n3)
{
   Console.WriteLine("Maximum number "+ max);
}
else
if (max < n3)
{
    max = n3;

    Console.WriteLine("Maximum number " + max);
}
