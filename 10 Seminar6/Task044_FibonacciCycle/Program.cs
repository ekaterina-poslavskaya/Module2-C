/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


using BasicArrFunc;
namespace Task040
{
    public class Task040
    {
        static int[] FibonacciCycle(int num)
        {
            int[] ar = new int[num];
            if (num == 0) {; }
            else if (num == 1) { ar[0] = 0; }
            else
            {
                ar[0] = 0;
                ar[1] = 1;
                for (int i = 2; i < num; i++)
                    ar[i] = ar[i - 1] + ar[i - 2];

            }
            return ar;

        }
        static void Main(string[] args)
        {
            int num = clsBasicArrFunc.ReadData("Введите число...");
            int[] arr = FibonacciCycle(num);
            clsBasicArrFunc.PrintArray(arr, $"Первые {num} числа Фибоначчи:");
        }
    }

}