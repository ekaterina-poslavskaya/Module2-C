/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/
using Basic2DimArrFunc;
using Basic1DimArrFunc;
using Basic3DimArrFunc;
using GeneralFunc;

public class clsTask62
{
    static private int Fill2DArraySpiral(int[,] A, 
                                          int indexOfFirstElem, 
                                          int indexOfLastElem,
                                          int beginValue
                                          ) // возвращает значение последнего 
                                          // заполненного элемента
    {
        int num = beginValue;
        // -->
        for (int j = indexOfFirstElem; j <= indexOfLastElem; j++)
        {
            A[indexOfFirstElem, j] = num;
            num++;
        }
       // вниз
        for (int i = indexOfFirstElem+1; i <= indexOfLastElem; i++)
        {
            A[i, indexOfLastElem] = num;
            num++;
        }
        // <--
        for (int j = indexOfLastElem-1; j >= indexOfFirstElem; j--)
        {
            A[indexOfLastElem, j] = num;
            num++;
        }
       // вверх
        for (int i = indexOfLastElem-1; i > indexOfFirstElem; i--)
        {
            A[i, indexOfFirstElem] = num;
            num++;
        }
        return num;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 62. Заполнение массива по спирали");
        Console.WriteLine("***********************************************");
        int razmernost = clsGeneralFunc.ReadIntData("Введите размерность квадратной матрицы");
        int [,] arr = new int[razmernost,razmernost];
        int numValue = 1;
       
        for (int k=0; k<razmernost/2; k++)
            numValue = Fill2DArraySpiral(arr, k, razmernost-k-1, numValue);

        clsBasic2DimArrFunc.Print2DimArray(arr);    
    }
}