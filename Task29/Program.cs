// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int [8];

    for (int i = 0; i < 8; i++)

        array[i] = new Random().Next(min, max + 1);

        return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");

    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} "); 

    Console.Write("]");
}
int[] ourArray = CreateRandomArray(8, 1, 100);
PrintArray(ourArray);

