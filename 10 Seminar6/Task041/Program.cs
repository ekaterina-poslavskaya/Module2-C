/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


using BasicArrFunc;
namespace Task041
{
    public class Task041
    {


        static int CountPositive(int[] ar)
        {
            int result = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > 0) result++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int num = clsBasicArrFunc.ReadData("Введите длину массива...");
            int[] arr = clsBasicArrFunc.ReadIntArray(num, "Введите элементы массива...", "элемент {i} = ");
            int cnt = CountPositive(arr);
            clsBasicArrFunc.PrintArray(arr, "Массив: ");
            Console.WriteLine($"Количество элементов > 0 = {cnt}");
        }
    }

}