/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
using Basic2DimArrFunc;

double[,] doubleArr = clsBasic2DimArrFunc.Init2DimDoubleArray(numRows: 0,
                                                              numCols: 0,
                                                              needPrintArray: true,
                                                              fromKeyboard: false,
                                                              needFillArray: true,
                                                              minA: 0,
                                                              maxA: 10);