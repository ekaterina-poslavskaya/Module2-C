/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
using Basic2DimArrFunc;
using GeneralFunc;

public class clsTask50
{
    static private double AverageSumByRows(int[,] intArr, int numCol)
    {
        double averageSum = 0;
        for (int i = 0; i < intArr.GetLength(0); i++)
            averageSum += intArr[i, numCol];
        if (intArr.GetLength(0) > 0) averageSum = averageSum / intArr.GetLength(0);
        return averageSum;
    }


    static void Main(string[] args)
    {

        int[,] intArr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                             numCols: 0,
                                                                      needPrintArray: true,
                                                                      fromKeyboard: false,
                                                                      needFillArray: true,
                                                                      minA: 0,
                                                                      maxA: 10);
        if ((intArr.GetLength(0) > 0) && (intArr.GetLength(1) > 1))
        {
            Console.WriteLine("Среднее арифметическое каждого столбца...");
            for (int j = 0; j < intArr.GetLength(1); j++)
            {
                Console.Write($"{AverageSumByRows(intArr, j)}\t");
            }
        }
    }
}