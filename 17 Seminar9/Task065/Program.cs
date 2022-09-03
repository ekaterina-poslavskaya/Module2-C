/*
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void PrintNumber(int m, int nMax)
{
    if (m == nMax)
    {
        Console.Write($"{m}, ");
        return;
    }
    else
    {
        Console.Write($"{m}, ");
        PrintNumber(m + 1, nMax);
    }

}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
PrintNumber(m, n);