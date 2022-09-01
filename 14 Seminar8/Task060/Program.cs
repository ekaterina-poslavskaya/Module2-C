/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
 двузначных чисел. Напишите программу, которая будет построчно 
 выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using Basic3DimArrFunc;
using GeneralFunc;

public class clsTask60
{
    static private void Fill3DArray(int[,,] A)
    {
        int num = 10;
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                for (int k = 0; k < A.GetLength(2); k++)
                {
                    A[i, j, k] = num;
                    num++;
                }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 60. Заполнение трехмерного массива");
        Console.WriteLine("***********************************************");
        int[,,] arr = clsBasic3DimArrFunc.Init3DimIntArray(numRows: 0,
                                                           numCols: 0,
                                                           numz: 0,
                                                           needPrintArray: false,
                                                           fromKeyboard: false,
                                                           needFillArray: false
                                                           );
        if (arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2) < 89)
        {
            Fill3DArray(arr);
            clsBasic3DimArrFunc.Print3DimArray(arr, "Трехмерный массив:");
        }
        else
            Console.WriteLine("Массив невозможно заполнить неповторяющимися двузначными числами, измените размерность массива");
    }
}