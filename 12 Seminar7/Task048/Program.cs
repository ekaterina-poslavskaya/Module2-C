/*Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
using Basic2DimArrFunc;

void FillMatrixBySumOfIndex()
{
    int[,] intArr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                         numCols: 0,
                                                         needPrintArray: false,
                                                         fromKeyboard: false,
                                                         needFillArray: false);

    for (int i = 0; i < intArr.GetLength(0); i++)
        for (int j = 0; j < intArr.GetLength(1); j++)
            intArr[i, j] = i + j;

    clsBasic2DimArrFunc.Print2DimArray(intArr, "массив по задаче 48:");

}

FillMatrixBySumOfIndex();


/*
Console.ForegroundColor = ConsoleColor.Blue;
Console.ResetColor();
*/   