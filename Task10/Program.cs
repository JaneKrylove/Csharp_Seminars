Console.WriteLine("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());


int SecondDigital(int number)

{
   
    int firtsnumber = number / 10;
    int secondnumber = firtsnumber % 10;

    

    return secondnumber;

}
        if (n1 < 999 || n1 > 99)
        {
        int result = SecondDigital(n1);
        Console.WriteLine("Вторая цифра " + result);
        }

    

    