/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
using Basic2DimArrFunc;
using GeneralFunc;

int[,] intArr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                     numCols: 0,
                                                              needPrintArray: true,
                                                              fromKeyboard: false,
                                                              needFillArray: true,
                                                              minA: 0,
                                                              maxA: 10);
int rowNum = clsGeneralFunc.ReadIntData("Введите номер строки элемента...");
int colNum = clsGeneralFunc.ReadIntData("Введите номер столбца элемента...");

if ((rowNum >= 0) && (rowNum < intArr.GetLength(0)) &&
    (colNum >= 0) && (colNum < intArr.GetLength(1)))
{ Console.WriteLine($"элемент [{rowNum}, {colNum}] = {intArr[rowNum, colNum]}"); }
else { Console.WriteLine($"элемента с индексами [{rowNum}, {colNum}] не существует"); }