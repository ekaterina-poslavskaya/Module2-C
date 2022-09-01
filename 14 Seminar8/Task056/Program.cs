/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using GeneralFunc;

public class clsTask56
{
    static private int SumOfElement(int[,] intArr, int numRow)
    {
        int sum = intArr[numRow, 0];
        for (int j = 1; j < intArr.GetLength(1); j++)
            sum += intArr[numRow, j];
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 56. Строка с минимальной суммой элементов");
        Console.WriteLine("***********************************************");
        int[,] arr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                           numCols: 0
                                                           );
        int[] arrOfSum = new int[arr.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arrOfSum[i] = SumOfElement(arr, i);
        }
        clsBasic1DimArrFunc.PrintArray(arrOfSum, "Сумма элементов массива построчно = ");

        Console.WriteLine($"Наименьшая сумма элементов в строке {clsBasic1DimArrFunc.IndexOfMinIn1DimArr(arrOfSum)}");

    }
}