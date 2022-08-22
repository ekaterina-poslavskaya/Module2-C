/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
void PrintArray(int[] A, string msgInBegin = "массив: ")
{
    Console.Write(msgInBegin + "[");
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

int[] InitArray(int len, int minA = Int32.MinValue, int maxA = Int32.MaxValue)
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
        if (minRandom == Int32.MinValue)
        {
            minRandom = ReadData("Введите нижнюю границу для генерации чисел...");
        }

        int maxRandom = maxA;
        if (maxRandom == Int32.MaxValue)
        {
            maxRandom = ReadData("Введите верхнюю границу для генерации чисел...");
        }

        FillArray(array, minRandom, maxRandom + 1);
        PrintArray(array);
        return array;
    }
    else
    {
        size = 0;//если размер меньше нуля указали или 0, то создаем нулевой массив и ругаемся
        int[] array = new int[size];
        Console.WriteLine("Длина массива должна быть больше 0");
        return array;//null;
    }
}


int[] MultiplyElements(int[] arS)
{
    int ln = 0;
    if (arS.Length % 2 == 0)
        ln = arS.Length / 2;
    else ln = arS.Length / 2 + 1;
    int[] res = new int[ln];
    for (int i = 0; i < arS.Length - 1 - i; i++)
    {
        res[i] = arS[i] * arS[arS.Length - 1 - i];
    }
    if (arS.Length % 2 == 1)
        res[arS.Length / 2 + 1 - 1] = arS[arS.Length / 2 + 1 - 1];//+1-1=0, 
                                                                  //но специально не убираю, т.к. сначала считаем индекс 
                                                                  //элемента как целое от деления+1 (т.к. знаем, что 
                                                                  //тут нечетное число), а потом удаляем 1, тк. 
                                                                  //индексация массива начинается с 0
    return res;
}


int[] ar = InitArray(0);
if (ar.Length > 0)
{
    int[] res = MultiplyElements(ar);
    PrintArray(res, "массив с результатом умножения ");

}