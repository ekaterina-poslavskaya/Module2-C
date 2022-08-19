/*
Задача 31: Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20
*/
void PrintArray(int[] A)
{
    Console.Write("массив: [");
    for (int i = 0; i < A.Length; i++)
        Console.Write($"{A[i]} ");
    Console.Write("]");
    Console.WriteLine("");
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

int[] InitArray(int len, int minA = -999999999, int maxA = -999999999)
{
    int size = len;
    if (size == 0)
    {
        Console.Write("Введите длину массива...");
        size = Convert.ToInt32(Console.ReadLine());
    }
    if (size > 0)
    {
        int[] array = new int[size];
        int minRandom = minA;
        if (minRandom == -999999999)
        {
            minRandom = ReadData("Введите нижнюю границу для генерации чисел...");
        }
        
        int maxRandom = maxA;
        if (maxRandom == -999999999)
        {
            maxRandom = ReadData("Введите верхнюю границу для генерации чисел...");
        }

        FillArray(array, minRandom, maxRandom + 1);
        PrintArray(array);
        return array;
    }
    else
    {
        Console.WriteLine("Длина массива должна быть больше 0");
        return null;
    }
}


int SumOfPositive(int[] arS)
{
    int result = 0;
    for (int i = 0; i < arS.Length; i++)
    {
        if (arS[i] > 0)
            result += arS[i];
    }
    return result;
}


int SumOfNegative(int[] arS)
{
    int result = 0;
    for (int i = 0; i < arS.Length; i++)
    {
        if (arS[i] < 0)
            result += arS[i];
    }
    return result;
}

int[] ar = InitArray(12, -9, 9);
if (ar.Length > 0)
{
    Console.WriteLine($"Сумма положительных элеметов = {SumOfPositive(ar)}");

    Console.WriteLine($"Сумма отрицательных элеметов = {SumOfNegative(ar)}");
}