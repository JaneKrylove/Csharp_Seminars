// Number 8

int n, index=1;

Console.WriteLine("Input number: ");
n=Convert.ToInt32(Console.ReadLine());

while (index<=n)
{
    if (index%2==0)
    {
        Console.WriteLine(index);
    }
    
    index++;
}   

