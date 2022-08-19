/*
Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


using BasicArrFunc;
namespace Task036
{
    public class Task036
    {
        private static int SumOddElements(int[] arS)
        {
            int res = 0;
            for (int i = 1; i < arS.Length; i+=2)//начинаем с первого нечетного, шаг 2
            {
                res+=arS[i];
            }
            return res;
        }


        static void Main(string[] args)
        {

            int[] ar = clsBasicArrFunc.InitArray(0, 1, 20);
            if (ar.Length > 0)
            {
                Console.WriteLine($"Сумма элементов с нечетными индексами = {SumOddElements(ar)}");

            }

        }
    }
}