/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
  и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void PrintArray(int[] A)
{
    Console.Write("массив: [");
    for (int i = 0; i < A.Length; i++)
        Console.Write($"{A[i]} ");
    Console.Write("]");
}

void FillArray(int[] A, int minValue, int maxValue)
{
    for (int i = 0; i < A.Length; i++)
        A[i] = new Random().Next(minValue, maxValue);
}

int ReadData(string comm)
{
    Console.Write(comm);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите длину массива...");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] array = new int[size];
    int minRandom = ReadData("Введите нижнюю границу для генерации чисел...");
    int maxRandom = ReadData("Введите верхнюю границу для генерации чисел...");

    FillArray(array, minRandom, maxRandom + 1);
    PrintArray(array);
}
else
{
    Console.WriteLine("Длина массива должна быть больше 0");
}