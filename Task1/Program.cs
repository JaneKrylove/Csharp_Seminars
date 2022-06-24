// Задача № 2

int n1, n2, max, min;

Console.WriteLine("Input first number: ");
n1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
n2=Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    max = n1;
    min = n2;

}
else   
    min = n1;
    max = n2;

    Console.WriteLine("Minumum number "+ min);
    Console.WriteLine ("Maximum number " + max);

