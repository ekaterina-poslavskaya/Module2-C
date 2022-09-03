/*
Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void PrintNumber(int i, int nMax)
{
    if (i == nMax)
    {
        Console.Write($"{i}, ");
        return;
    }
    else
    {
        Console.Write($"{i}, ");
        PrintNumber(i + 1, nMax);
    }

}

int n = Convert.ToInt32(Console.ReadLine());
PrintNumber(1, n);