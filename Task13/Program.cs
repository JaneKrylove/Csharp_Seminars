Console.WriteLine("Input number: ");
string? n1 = Console.ReadLine();

void FindThirdDigital(string number)
{
    int result = 0;
    if(number.Length == 3)
    {
        result = Convert.ToInt32(number);
        result = result % 10;
        Console.WriteLine(result);
      
    } else if(number.Length < 3)
    {
        Console.WriteLine("третьей цифры нет");
    } else if (number.Length > 3)
    {
        int count = number.Length;                                  //Если число более трёх знаков
        int stepen = count -3;
        result = Convert.ToInt16(number);
        int delitel = (int)Math.Pow(10, stepen);
        int newResult = result / delitel;

        int lastResult = Convert.ToInt32(newResult % 10);

        Console.WriteLine(lastResult); 
    }

     
}

FindThirdDigital(n1); 

