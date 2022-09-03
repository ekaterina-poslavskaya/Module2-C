/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
*/
using GeneralFunc;
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else return -1;
}


int m = clsGeneralFunc.ReadIntData("Введите m=");
int n = clsGeneralFunc.ReadIntData("Введите n=");
if ((m >= 0) && (n >= 0))
    Console.WriteLine($"{Akkerman(m, n)}");
