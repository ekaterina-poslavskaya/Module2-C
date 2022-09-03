/*
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/
using GeneralFunc;
void PrintNumber(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}\t");
        return;
    }
    else
    {
        Console.Write($"{m}\t");
        PrintNumber(m + 1, n);
    }

}


int m = clsGeneralFunc.ReadIntData("Введите нижнюю границу диапазона..");
int n = clsGeneralFunc.ReadIntData("Введите верхнюю границу диапазона..");
if (m <= n) PrintNumber(m, n);
else PrintNumber(n, m);