/*
Задача 39: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом месте, 
а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
using BasicArrFunc;
namespace Task039
{
    public class Task039
    {
        static void InverseArray(int[] arS)
        {
            for (int i = 0; i < arS.Length/2; i++)
            {
                int tmp = arS[i];
                arS[i] = arS[arS.Length - 1 - i];
                arS[arS.Length - 1 - i] = tmp;
            }
        }


        static void Main(string[] args)
        {

            int[] ar = clsBasicArrFunc.InitArray(0, Int32.MinValue, Int32.MaxValue);
            if (ar.Length > 0)
            {
                InverseArray(ar);
                clsBasicArrFunc.PrintArray(ar, "перевернутый массив: ");

            }

        }
    }
}