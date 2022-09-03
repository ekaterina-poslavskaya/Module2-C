//основные методы работы с массивами
using GeneralFunc;

namespace Basic2DimArrFunc
{
    public class clsBasic2DimArrFunc
    {


        public static int FindMinIn2DimArr(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (min > arr[i, j]) min = arr[i, j];
            return min;
        }
        private static int FindMaxIn2DimArr(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (max < arr[i, j]) max = arr[i, j];
            return max;
        }
        // печать массива
        public static void Print2DimArray(int[,] A, string msgInBegin = "массив: ")
        {
            Console.WriteLine(msgInBegin);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write($"{A[i, j]}\t");
                Console.WriteLine();
            }
            Console.WriteLine("");
        }// печать массива
        public static void Print2DimArray(double[,] A,
                                          string msgInBegin = "массив: ")
        {
            Console.WriteLine(msgInBegin);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write($"{A[i, j]}\t");
                Console.WriteLine();
            }
            Console.WriteLine("");
        }

        // наполнение массива значениями
        public static void Fill2DimArray(int[,] A, int minValue, int maxValue)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = new Random().Next(minValue, maxValue);
        }
        // наполнение массива значениями
        public static void Fill2DimArray(double[,] A, double minValue, double maxValue)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
        // наполнение массива значениями с клавиатуры
        public static void Fill2DimArrayFromKeyboard(int[,] A, string message1 = "", string message2 = "")
        {
            if (message1 != String.Empty) Console.WriteLine(message1);
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = clsGeneralFunc.ReadIntData(message2 + "[" + i.ToString() +
                                                                  ", " + j.ToString() +
                                                                  "]");

        }
        // наполнение массива значениями с клавиатуры
        public static void Fill2DimArrayFromKeyboard(double[,] A, string message1 = "", string message2 = "")
        {
            if (message1 != String.Empty) Console.WriteLine(message1);
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = clsGeneralFunc.ReadDoubleData(message2 + "[" + i.ToString() +
                                                                  ", " + j.ToString() +
                                                                  "]");

        }

        // инициализация и заполнение массива
        public static int[,] Init2DimIntArray(int numRows, int numCols,
                                                bool needPrintArray = true, //признак, надо ли печатать массив 
                                                                            //  после его инициализации
                                                bool fromKeyboard = false, //признак, надо ли считывать массив 
                                                                           //  с клавиатуры
                                                                           // true - игнорируются minA и maxA
                                                bool needFillArray = true, //признак, надо ли заполнять массив
                                                                           // случайными числами
                                                                           //fromKeyboard и needFillArray 
                                                                           // не являются взаимоисклю, тк бывают 
                                                                           // ситуации, что массив надо только 
                                                                           // инициализировать, а заполняться
                                                                           // будет где-то вне по особому алгоритму
                                                int minA = Int32.MinValue,
                                                int maxA = Int32.MaxValue)
        {
            int rows = numRows;
            int cols = numCols;
            if (rows == 0) rows = clsGeneralFunc.ReadIntData("Введите количество строк массива...");
            if (cols == 0) cols = clsGeneralFunc.ReadIntData("Введите количество столбцов массива...");

            if ((rows > 0) && (cols > 0))
            {
                int[,] array = new int[rows, cols];
                if ((!fromKeyboard) && (needFillArray))
                {
                    int minRandom = minA;
                    if (minRandom == Int32.MinValue)
                    {
                        minRandom = clsGeneralFunc.ReadIntData("Введите нижнюю границу для генерации чисел...");
                    }

                    int maxRandom = maxA;
                    if (maxRandom == Int32.MaxValue)
                    {
                        maxRandom = clsGeneralFunc.ReadIntData("Введите верхнюю границу для генерации чисел...");
                    }

                    Fill2DimArray(array, minRandom, maxRandom + 1);
                }
                if ((fromKeyboard) && (!needFillArray)) Fill2DimArrayFromKeyboard(array, "Введите массив...", "элемент ");

                if (needPrintArray) Print2DimArray(array);
                return array;
            }
            else
            {
                rows = 0;//если размер меньше нуля указали или 0, то создаем нулевой массив и ругаемся
                cols = 0;
                int[,] array = new int[rows, cols];
                Console.WriteLine("Количество строк и столбцов массива должно быть больше 0");
                return array;//null;
            }
        }


        // инициализация и заполнение массива
        public static double[,] Init2DimDoubleArray(int numRows, int numCols,
                                                bool needPrintArray = true, //признак, надо ли печатать массив 
                                                                            //  после его инициализации
                                                bool fromKeyboard = false, //признак, надо ли считывать массив 
                                                                           //  с клавиатуры
                                                                           // true - игнорируются minA и maxA
                                                bool needFillArray = true, //признак, надо ли заполнять массив
                                                                           // случайными числами
                                                                           //fromKeyboard и needFillArray 
                                                                           // не являются взаимоисклю, тк бывают 
                                                                           // ситуации, что массив надо только 
                                                                           // инициализировать, а заполняться
                                                                           // будет где-то вне по особому алгоритму
                                                double minA = -999999999999,
                                                double maxA = 999999999999)
        {
            int rows = numRows;
            int cols = numCols;
            if (rows == 0) rows = clsGeneralFunc.ReadIntData("Введите количество строк массива...");
            if (cols == 0) cols = clsGeneralFunc.ReadIntData("Введите количество столбцов массива...");

            if ((rows > 0) && (cols > 0))
            {
                double[,] array = new double[rows, cols];
                if ((!fromKeyboard) && (needFillArray))
                {
                    double minRandom = minA;
                    if (minRandom == -999999999999)
                    {
                        minRandom = clsGeneralFunc.ReadDoubleData("Введите нижнюю границу для генерации чисел...");
                    }

                    double maxRandom = maxA;
                    if (maxRandom == 999999999999)
                    {
                        maxRandom = clsGeneralFunc.ReadDoubleData("Введите верхнюю границу для генерации чисел...");
                    }

                    Fill2DimArray(array, minRandom, maxRandom + 1);
                }
                if ((fromKeyboard) && (!needFillArray)) Fill2DimArrayFromKeyboard(array, "Введите массив...", "элемент ");

                if (needPrintArray) Print2DimArray(array);
                return array;
            }
            else
            {
                rows = 0;//если размер меньше нуля указали или 0, то создаем нулевой массив и ругаемся
                cols = 0;
                double[,] array = new double[rows, cols];
                Console.WriteLine("Количество строк и столбцов массива должно быть больше 0");
                return array;//null;
            }
        }
        public static int[] GetRowAsArray(int[,] intArr, int numRow)
        {
            int[] resArr = new int[intArr.GetLength(1)];
            for (int i = 0; i < intArr.GetLength(1); i++)
                resArr[i] = intArr[numRow, i];
            return resArr;
        }

        public static void SetArrayAsRow(int[,] intArr, int numRow, int[] rowArr)
        {
            for (int i = 0; i < rowArr.Length; i++)
                intArr[numRow, i] = rowArr[i];
        }
        public static int RowPosByElement(int[,] arr, int num)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == num) { return i; }
            return -1;
        }

        public static int ColPosByElement(int[,] arr, int num)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == num) { return j; }
            return -1;
        }
    }
}