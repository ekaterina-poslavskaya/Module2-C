/*Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых 
расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using GeneralFunc;

public class clsTask59
{


    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 59. Удаление строки и столбца наименьшего элемента");
        Console.WriteLine("***********************************************");
        int[,] arr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                           numCols: 0
                                                           );
        int min = clsBasic2DimArrFunc.FindMinIn2DimArr(arr);
        int row = clsBasic2DimArrFunc.RowPosByElement(arr, min);
        int col = clsBasic2DimArrFunc.ColPosByElement(arr, min);
        if ((row != -1) && (col != -1) &&
            (arr.GetLength(0) >= 1) && (arr.GetLength(1) >= 1))
        {
            int[,] resArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int l = 0;
                if (i != row)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j != col)
                        {
                            resArr[k, l] = arr[i, j];
                            l++;
                        }
                    }
                    k++;
                }
            }
            Console.WriteLine("***********************************************");
            Console.WriteLine("Измененный массив");
            clsBasic2DimArrFunc.Print2DimArray(resArr);
        }
    }
}