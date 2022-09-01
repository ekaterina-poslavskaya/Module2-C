/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using GeneralFunc;

public class clsTask58
{
    static private int MultiplyVectors(int[,] intArr1, int numRow,
                                       int[,] intArr2, int numCol)
    {
        Console.WriteLine($"numRow={numRow}; numCol = {numCol}");
        int sum = 0;
        for (int k = 0; k < intArr1.GetLength(1); k++)//intArr1.GetLength(1) == intArr2.GetLength(0)
            sum += intArr1[numRow, k] * intArr2[k, numCol];
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 58. Произведение матриц");
        Console.WriteLine("***********************************************");
        int[,] arr1 = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                           numCols: 0
                                                           );
        //создаем второй массив с учетом условия совместимости:
        // число столбцов первой матрицы = числу строк второй матрицы
        int[,] arr2 = clsBasic2DimArrFunc.Init2DimIntArray(numRows: arr1.GetLength(1),
                                                           numCols: 0
                                                           );

        int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++) //по строкам первого массива
            for (int j = 0; j < arr2.GetLength(1); j++) //по столбцам второго массива
                res[i, j] = MultiplyVectors(arr1, i, arr2, j);

        clsBasic2DimArrFunc.Print2DimArray(res, "Скалярное произведение матриц:");
    }
}