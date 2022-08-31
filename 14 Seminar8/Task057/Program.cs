/*Задача 57. Задача 57: Составить частотный словарь элементов двумерного 
массива. Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных.

{ 1, 9, 9, 0, 2, 8, 0, 9 } => 
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза

1, 2, 3 
4, 6, 1 
2, 1, 6
=>
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза

*/
using Basic2DimArrFunc;
using BasicArrFunc;
using GeneralFunc;

public class clsTask57
{

    private static int FindMaxIn2DimArr(int[,] arr)
    {
        int max = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                if (max < arr[i, j]) max = arr[i, j];
        return max;
    }
    private static int FindMinIn2DimArr(int[,] arr)
    {
        int min = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                if (min > arr[i, j]) min = arr[i, j];
        return min;
    }
    static private void FrequentElementIn2DimArray()
    {
        //работа с двумерными массивами
        int[,] intArr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                             numCols: 0,
                                                                      needPrintArray: true,
                                                                      fromKeyboard: false,
                                                                      needFillArray: true,
                                                                      minA: Int32.MinValue,
                                                                      maxA: Int32.MaxValue);

        if ((intArr.GetLength(0) > 0) && (intArr.GetLength(1) > 1))
        {
            int minValue = FindMinIn2DimArr(intArr);
            //Console.WriteLine($"Минимальное значение {minValue}");
            int maxValue = FindMaxIn2DimArr(intArr);
            //Console.WriteLine($"Максимальное значение {maxValue}");
            // создаем массив для всех значений из диапазона значений массива
            int[] resArr = new int[maxValue - minValue + 1];
            //обнуляем массив с результатами частотного анализа
            for (int i = minValue; i < maxValue + 1; i++)
            { resArr[i - minValue] = 0; }

            for (int i = 0; i < intArr.GetLength(0); i++)
                for (int j = 0; j < intArr.GetLength(1); j++)
                {
                    //Console.WriteLine($"Для значения intArr[{i},{j}]={intArr[i, j]} записываем в индекс {intArr[i, j] - minValue}");
                    resArr[intArr[i, j] - minValue]++;
                }

            //а теперь выводим частоту встречаемых значений с поправкой на реальный 
            //  диапазон значений (массив с 0 нумеруется, реальный диапазон может  
            //  начинаться с отрицательного значения)
            for (int i = 0; i < resArr.Length; i++)
                if (resArr[i] > 0)
                { Console.WriteLine($"Число {i + minValue} встречается {resArr[i]} раз"); }

        }
        else
        {
            int[] resArr = new int[0];
            //return resArr;
        }
    }


    static void Main(string[] args)
    {
        FrequentElementIn2DimArray();

    }
}