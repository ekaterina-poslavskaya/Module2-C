//основные методы работы с массивами
using GeneralFunc;

namespace Basic3DimArrFunc
{
    public class clsBasic3DimArrFunc
    {


        public static int FindMinIn3DimArr(int[,,] arr)
        {
            int min = arr[0, 0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                        if (min > arr[i, j, k]) min = arr[i, j, k];
            return min;
        }
        private static int FindMaxIn3DimArr(int[,,] arr)
        {
            int max = arr[0, 0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                        if (max < arr[i, j, k]) max = arr[i, j, k];
            return max;
        }
        // печать массива
        public static void Print3DimArray(int[,,] A, string msgInBegin = "массив: ")
        {
            Console.WriteLine(msgInBegin);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(2); k++)
                        Console.Write($"{A[i, j, k]} ({i},{j},{k})\t");
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
            Console.WriteLine("");
        }// печать массива
        public static void Print3DimArray(double[,,] A,
                                          string msgInBegin = "массив: ")
        {
            Console.WriteLine(msgInBegin);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(2); k++)
                        Console.Write($"{A[i, j, k]} ({i},{j},{k})\t");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }

        // наполнение массива значениями
        public static void Fill3DimArray(int[,,] A, int minValue, int maxValue)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    for (int k = 0; k < A.GetLength(2); k++)
                        A[i, j, k] = new Random().Next(minValue, maxValue);
        }
        // наполнение массива значениями
        public static void Fill3DimArray(double[,,] A, double minValue, double maxValue)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    for (int k = 0; k < A.GetLength(2); k++)
                        A[i, j, k] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
        // наполнение массива значениями с клавиатуры
        public static void Fill3DimArrayFromKeyboard(int[,,] A, string message1 = "", string message2 = "")
        {
            if (message1 != String.Empty) Console.WriteLine(message1);
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    for (int k = 0; k < A.GetLength(2); k++)
                        A[i, j, k] = clsGeneralFunc.ReadIntData(message2 + "[" + i.ToString() +
                                                                      ", " + j.ToString() +
                                                                      ", " + k.ToString() +
                                                                      "]");

        }
        // наполнение массива значениями с клавиатуры
        public static void Fill3DimArrayFromKeyboard(double[,,] A, string message1 = "", string message2 = "")
        {
            if (message1 != String.Empty) Console.WriteLine(message1);
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    for (int k = 0; k < A.GetLength(2); k++)
                        A[i, j, k] = clsGeneralFunc.ReadDoubleData(message2 + "[" + i.ToString() +
                                                                      ", " + j.ToString() +
                                                                      ", " + k.ToString() +
                                                                      "]");

        }

        // инициализация и заполнение массива
        public static int[,,] Init3DimIntArray(int numRows, int numCols, int numz,
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
            int z = numz;
            if (rows == 0) rows = clsGeneralFunc.ReadIntData("Введите количество строк массива...");
            if (cols == 0) cols = clsGeneralFunc.ReadIntData("Введите количество столбцов массива...");
            if (z == 0) z = clsGeneralFunc.ReadIntData("Введите количество элементов третьего измерения массива...");

            if ((rows > 0) && (cols > 0) && (z > 0))
            {
                int[,,] array = new int[rows, cols,z];
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

                    Fill3DimArray(array, minRandom, maxRandom + 1);
                }
                if ((fromKeyboard) && (!needFillArray)) Fill3DimArrayFromKeyboard(array, "Введите массив...", "элемент ");

                if (needPrintArray) Print3DimArray(array);
                return array;
            }
            else
            {
                rows = 0;//если размер меньше нуля указали или 0, то создаем нулевой массив и ругаемся
                cols = 0;
                z = 0;
                int[,,] array = new int[rows, cols,z];
                Console.WriteLine("Количество строк, столбцов и элементов третьего измерения массива должно быть больше 0");
                return array;//null;
            }
        }


        // инициализация и заполнение массива
        public static double[,,] Init3DimDoubleArray(int numRows, int numCols, int numz,
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
            int z = numz;
            if (rows == 0) rows = clsGeneralFunc.ReadIntData("Введите количество строк массива...");
            if (cols == 0) cols = clsGeneralFunc.ReadIntData("Введите количество столбцов массива...");
if (z == 0) z = clsGeneralFunc.ReadIntData("Введите количество элементов третьего измерения массива...");

            if ((rows > 0) && (cols > 0) && (z > 0))
            {
                double[,,] array = new double[rows, cols, z];
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

                    Fill3DimArray(array, minRandom, maxRandom + 1);
                }
                if ((fromKeyboard) && (!needFillArray)) Fill3DimArrayFromKeyboard(array, "Введите массив...", "элемент ");

                if (needPrintArray) Print3DimArray(array);
                return array;
            }
            else
            {
                rows = 0;//если размер меньше нуля указали или 0, то создаем нулевой массив и ругаемся
                cols = 0;
                z = 0;
                double[,,] array = new double[rows, cols,z];
                Console.WriteLine("Количество строк, столбцов и элементов третьего измерения массива должно быть больше 0");
                return array;//null;
            }
        }
        
        
    }
}