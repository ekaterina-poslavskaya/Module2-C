//основные методы работы с массивами
using GeneralFunc;

namespace Basic1DimArrFunc
{
    public class clsBasic1DimArrFunc
    {
        // печать массива
        public static void PrintArray(int[] A, string msgInBegin = "массив: ")
        {
            Console.Write(msgInBegin + "[");
            for (int i = 0; i < A.Length; i++)
                Console.Write($"{A[i]} ");
            Console.Write("]");
            Console.WriteLine("");
        }

        // наполнение массива значениями
        public static void FillArray(int[] A, int minValue, int maxValue)
        {
            for (int i = 0; i < A.Length; i++)
                A[i] = new Random().Next(minValue, maxValue);
        }

        // инициализация и заполнение массива
        public static int[] InitArray(int len, int minA = Int32.MinValue, int maxA = Int32.MaxValue)
        {
            int size = len;
            if (size == 0)
            {
                size = clsGeneralFunc.ReadIntData("Введите длину массива...");
            }
            if (size > 0)
            {
                int[] array = new int[size];
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

                FillArray(array, minRandom, maxRandom + 1);
                PrintArray(array);
                return array;
            }
            else
            {
                size = 0;//если размер меньше нуля указали или 0, то создаем нулевой массив и ругаемся
                int[] array = new int[size];
                Console.WriteLine("Длина массива должна быть больше 0");
                return array;//null;
            }
        }

        // печать массива
        public static void PrintArray(double[] A, string msgInBegin = "массив: ")
        {
            Console.Write(msgInBegin + "[");
            for (int i = 0; i < A.Length; i++)
                Console.Write($"{A[i]} ");
            Console.Write("]");
            Console.WriteLine("");
        }

        // наполнение массива значениями
        public static void FillArray(double[] A, double minValue, double maxValue)
        {
            for (int i = 0; i < A.Length; i++)
                A[i] = (new Random().NextDouble()) * maxValue - minValue;
        }

        // инициализация и заполнение массива
        public static double[] InitArray(int len, double minA = Int32.MinValue, double maxA = Int32.MaxValue)
        {
            int size = len;
            if (size == 0)
            {
                size = clsGeneralFunc.ReadIntData("Введите длину массива...");
            }
            if (size > 0)
            {
                double[] array = new double[size];
                double minRandom = minA;
                if (minRandom == Int32.MinValue)
                {
                    minRandom = clsGeneralFunc.ReadDoubleData("Введите нижнюю границу для генерации чисел...");
                }

                double maxRandom = maxA;
                if (maxRandom == Int32.MaxValue)
                {
                    maxRandom = clsGeneralFunc.ReadDoubleData("Введите верхнюю границу для генерации чисел...");
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
        }
    }
}