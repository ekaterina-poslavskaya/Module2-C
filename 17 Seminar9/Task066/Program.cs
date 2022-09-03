/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using GeneralFunc;
int SumNumber(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumNumber(m + 1, n);
    }

}


int m = clsGeneralFunc.ReadIntData("Введите нижнюю границу диапазона..");
int n = clsGeneralFunc.ReadIntData("Введите верхнюю границу диапазона..");
if (m <= n) Console.WriteLine($"{SumNumber(m, n)}");
else Console.WriteLine($"{SumNumber(n, m)}");