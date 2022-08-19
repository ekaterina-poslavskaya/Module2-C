/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие 
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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


void InverseArray(int[] arS)
{
    for (int i = 0; i < arS.Length; i++)
    {
        arS[i]*=-1;
    }
}


int[] ar = InitArray(0);
if (ar.Length > 0)
{
    InverseArray(ar);
    PrintArray(ar);
}