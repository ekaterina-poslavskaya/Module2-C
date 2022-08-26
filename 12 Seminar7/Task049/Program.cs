/*Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/
using Basic2DimArrFunc;

void Print2DimArrayInColor(int[,] A, string msgInBegin = "массив: ")
{
    Console.WriteLine(msgInBegin);
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{A[i, j]}\t");
                Console.ResetColor();
            }
            else Console.Write($"{A[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine("");
}

void ReplaceEvenIndexElementByElemQuad()
{
    int[,] intArr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                         numCols: 0,
                                                         needPrintArray: true,
                                                         fromKeyboard: false,
                                                         needFillArray: true);

    for (int i = 0; i < intArr.GetLength(0); i += 2)//шагаем только по четным индексам
        for (int j = 0; j < intArr.GetLength(1); j += 2)
            intArr[i, j] = intArr[i, j] * intArr[i, j];

    //clsBasic2DimArrFunc.Print2DimArray(intArr, "Измененный массив:");
    Print2DimArrayInColor(intArr, "Измененный массив:");
}

ReplaceEvenIndexElementByElemQuad();


