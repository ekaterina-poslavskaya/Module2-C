//основные методы работы с массивами
using GeneralFunc;

namespace Basic2DimArrFunc
{
    public class clsBasic2DimArrFunc
    {
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
        }

        // наполнение массива значениями
        public static void Fill2DimArray(int[,] A, int minValue, int maxValue)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = new Random().Next(minValue, maxValue);
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

        // печать массива
        /*        public static void PrintArray(double[] A, string msgInBegin = "массив: ")
                {
                    Console.Write(msgInBegin + "[");
                    for (int i = 0; i < A.Length; i++)
                        Console.Write($"{A[i]} ");
                    Console.Write("]");
                    Console.WriteLine("");
                }*/

        // наполнение массива значениями
        /*        public static void FillArray(double[] A, double minValue, double maxValue)
                {
                    for (int i = 0; i < A.Length; i++)
                        A[i] = (new Random().NextDouble()) * maxValue - minValue;
                }*/

        // инициализация и заполнение массива
        /*       public static double[] InitDoubleArray(int len, double minA = Int32.MinValue, double maxA = Int32.MaxValue)
               {
                   int size = len;
                   if (size == 0)
                   {
                       Console.Write("Введите длину массива...");
                       size = Convert.ToInt32(Console.ReadLine());
                   }
                   if (size > 0)
                   {
                       double[] array = new double[size];
                       double minRandom = minA;
                       if (minRandom == Int32.MinValue)
                       {
                           minRandom = ReadDoubleData("Введите нижнюю границу для генерации чисел...");
                       }

                       double maxRandom = maxA;
                       if (maxRandom == Int32.MaxValue)
                       {
                           maxRandom = ReadDoubleData("Введите верхнюю границу для генерации чисел...");
                       }

                       FillArray(array, minRandom, maxRandom);
                       PrintArray(array);
                       return array;
                   }
                   else
                   {
                       size = 0;//если размер меньше нуля указали или 0, то создаем нулевой массив и ругаемся
                       double[] array = new double[size];
                       Console.WriteLine("Длина массива должна быть больше 0");
                       return array;//null;
                   }
               }*/
    }
}