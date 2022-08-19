/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

using BasicArrFunc;
namespace Task038
{
    public class Task038
    {
        private static double FindMaxElement(double[] arS)
        {
            double res = arS[0];
            for (int i = 1; i < arS.Length; i++)
            {
                if (arS[i] > res) res = arS[i];
            }
            return res;
        }
        private static double FindMinElement(double[] arS)
        {
            double res = arS[0];
            for (int i = 1; i < arS.Length; i++)
            {
                if (arS[i] < res) res = arS[i];
            }
            return res;
        }


        static void Main(string[] args)
        {

            double[] ar = clsBasicArrFunc.InitArray(0, 1.0, 20.0);
            if (ar.Length > 0)
            {
                double MaxE = FindMaxElement(ar);
                double MinE = FindMinElement(ar);
                Console.WriteLine($"Разница между макс ({MaxE}) и мин ({MinE}) = {MaxE - MinE}");

            }

        }
    }
}