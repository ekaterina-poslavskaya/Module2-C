/*
Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
using BasicArrFunc;

namespace Task034
{
    public class Task034
    {
        private static int CountPositiveElements(int[] arS)
        {
            int res = 0;
            for (int i = 0; i < arS.Length; i++)
            {
                if (arS[i] % 2 == 0) res++;
            }
            return res;
        }


        static void Main(string[] args)
        {

            int[] ar = clsBasicArrFunc.InitArray(0, 100, 999);
            if (ar.Length > 0)
            {
                Console.WriteLine($"Количество четных чисел в массиве = {CountPositiveElements(ar)}");

            }

        }
    }
}