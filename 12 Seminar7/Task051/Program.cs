/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
using Basic2DimArrFunc;

void SumElementOnMainDiag()
{
    int[,] intArr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                         numCols: 0,
                                                         needPrintArray: true,
                                                         fromKeyboard: false,
                                                         needFillArray: true);

    int cnt=0;
    if (intArr.GetLength(0)<intArr.GetLength(1)) cnt = intArr.GetLength(0);
    else cnt =intArr.GetLength(1);

    int sumDiag = 0;
    for (int i = 0; i < cnt; i ++)//шагаем по главной диагонали только
        sumDiag = sumDiag + intArr[i, i];

    Console.WriteLine($"Сумма элементов главной диагонали равна {sumDiag}");
}

SumElementOnMainDiag();


