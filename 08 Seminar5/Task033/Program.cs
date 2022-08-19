/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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


int FindNumber(int[] arS, int num)
{
    int result = -1;
    for (int i = 0; i < arS.Length; i++)
    {
        if (arS[i] == num)
        {
            result = i;
            break;
        };
    }
    return result;
}


int[] ar = InitArray(0);
if (ar.Length > 0)
{
    int num = ReadData("Введите число для поиска...");
    int pos = FindNumber(ar, num);
    if (pos != -1)
        Console.WriteLine($"Число {num} находится на позиции {pos}");
    else
        Console.WriteLine($"Число {num} отсутствует в массиве");
}