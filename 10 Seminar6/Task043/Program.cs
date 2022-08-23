/*
Задача 43. Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

k1*x +b1 = k2*x + b2
x = (b2 - b1) / (k1 - k2)
y = k2 * (b2 - b1) / (k1 - k2) + b2
*/


using BasicArrFunc;
namespace Task043
{
    public class Task043
    {

        static string LineIntersect(double B1, double K1, double B2, double K2)
        {
            string res = String.Empty;
            if (K1 != K2)
            {
                double x = (B2 - B1) / (K1 - K2);
                double y = K2 * x + B2;
                res = $"Точка пересечения прямых ({x};{y})";
            }
            else
                res = "Прямые не пересекаются, параллельны";
            return res;
        }
        static void Main(string[] args)
        {
            int B1 = clsBasicArrFunc.ReadData("Введите коэф B1...");
            int K1 = clsBasicArrFunc.ReadData("Введите коэф K1...");
            int B2 = clsBasicArrFunc.ReadData("Введите коэф B2...");
            int K2 = clsBasicArrFunc.ReadData("Введите коэф K2...");

            Console.WriteLine(LineIntersect(Convert.ToDouble(B1), 
                                            Convert.ToDouble(K1), 
                                            Convert.ToDouble(B2), 
                                            Convert.ToDouble(K2)));

        }
    }

}