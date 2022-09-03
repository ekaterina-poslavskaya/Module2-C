/*Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это 
невозможно, программа должна вывести сообщение для пользователя

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using GeneralFunc;

public class clsTask55
{


    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 55. Транспонирование матриц");
        Console.WriteLine("***********************************************");
        int[,] arr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                           numCols: 0
                                                           );
        int[,] resArr = new int[arr.GetLength(1), arr.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                resArr[j, i] = arr[i, j];
            }
        Console.WriteLine("***********************************************");
        Console.WriteLine("Измененный массив");
        clsBasic2DimArrFunc.Print2DimArray(resArr);
    }
}