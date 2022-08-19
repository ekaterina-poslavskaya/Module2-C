/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат 
в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении 
сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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


int FindNumberFromInterval(int[] arS, int minNum, int maxNum)
{
    int result = 0;
    for (int i = 0; i < arS.Length; i++)
    {
        if ((arS[i] <= maxNum) && (arS[i]>=minNum))
        {
            result++;
        };
    }
    return result;
}


int[] ar = InitArray(123);
if (ar.Length > 0)
{
    Console.WriteLine($"Количество элементов из диапазона равно {FindNumberFromInterval(ar,10,99)}");
}