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
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " "); 

    Console.WriteLine();
}
int[] ourArray = CreateRandomArray(8, 1, 100);
PrintArray(ourArray);

