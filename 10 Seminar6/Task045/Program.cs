/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


using BasicArrFunc;
namespace Task045
{
    public class Task045
    {
        static int[] CopyArray(int[] ar_in)
        {
            int[] ar_out = new int[ar_in.Length];
            for (int i = 0; i < ar_in.Length; i++)
                ar_out[i] = ar_in[i];

            return ar_out;

        }
        static void Main(string[] args)
        {
            int[] arr1 = clsBasicArrFunc.InitArray(0, Int32.MinValue, Int32.MaxValue);
            clsBasicArrFunc.PrintArray(arr1, "первый массив: ");
            int[] arr2 = CopyArray(arr1);
            clsBasicArrFunc.PrintArray(arr2, "второй массив: ");

            Console.WriteLine("....Внесли изменения во второй массив...");
            arr2[0] = 1;
            clsBasicArrFunc.PrintArray(arr1, "первый массив: ");
            clsBasicArrFunc.PrintArray(arr2, "второй массив: ");
        }
    }

}