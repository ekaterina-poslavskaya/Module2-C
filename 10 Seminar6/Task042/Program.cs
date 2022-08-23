/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
using BasicArrFunc;
namespace Task042
{
    public class Task042
    {
        static string StrConvert2Binary(int A)
        {
            string res = string.Empty;
            if (A == 0) res = "0";
            else
            {
                while (A >= 1)
                {
                    res = A % 2 + res;
                    A = A / 2;
                }
                if (A == 1) res = A + res;
            }
            return res;
        }


        static void Main(string[] args)
        {
            int Num = clsBasicArrFunc.ReadData("Введите число...");
            string strNumBinary = StrConvert2Binary(Num);
            Console.WriteLine($"Число в 2-ой системе = {strNumBinary}");
           
        }
    }
}