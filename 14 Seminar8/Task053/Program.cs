/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами 
первую и последнюю строку массива.

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using GeneralFunc;

public class clsTask53
{


    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 53. Обмен первой и последней строками");
        Console.WriteLine("***********************************************");
        int[,] arr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                           numCols: 0
                                                           );
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int t = arr[0,j];
            arr[0,j]=arr[arr.GetLength(0)-1,j];
            arr[arr.GetLength(0)-1,j] = t;
        }
        Console.WriteLine("***********************************************");
        Console.WriteLine("Измененный массив");
        clsBasic2DimArrFunc.Print2DimArray(arr);
    }
}