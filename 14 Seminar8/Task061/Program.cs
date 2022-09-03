/*Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using GeneralFunc;

public class clsTask61
{


    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 61. Треугольник Паскаля");
        Console.WriteLine("***********************************************");
        int n = clsGeneralFunc.ReadIntData("Введите число строк треугольника Паскаля..");
        int colnum = n * 2 - 1;
        int[,] arr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: n,
                                                           numCols: colnum,
                                                           needPrintArray: false,
                                                           needFillArray: false
                                                           );
        arr[0, colnum / 2] = 1;
        for (int i = 1; i < n; i++)
        {
            if ((colnum / 2 - i >= 0) && (colnum / 2 + i < colnum))
            {
                for (int j = colnum / 2 - i; j <= colnum / 2 + i; j++)
                {
                    if (j == colnum / 2 - i) arr[i, j] = 1;
                    else if (j == colnum / 2 + i) arr[i, j] = 1;
                    else arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j + 1];
                    //Console.Write($"{arr[i, j]}\t");
                }
            }
            //Console.WriteLine();
        }
        Console.WriteLine("***********************************************");
        Console.WriteLine("Треугольник Паскаля");
        //clsBasic2DimArrFunc.Print2DimArray(arr);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < colnum; j++)
                if (arr[i, j] > 0) Console.Write("*");
                else Console.Write(" ");
            Console.WriteLine();
        }
    }
}