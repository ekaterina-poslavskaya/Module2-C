/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int MultiplyA(int a)
{
    int result = 1;

    if (a > 0)
        {for (int i = 1; i <= a; i++)
            result *= i;}
    else
        {for (int i = -1; i >= a; i--)
            result *= i;}

    return result;
}

void PrintMultiplyA(int a)
{
    Console.WriteLine($"Произведение чисел от 1 до {a} равна {MultiplyA(a)}");

}

PrintMultiplyA(0);
PrintMultiplyA(4);
PrintMultiplyA(5);
PrintMultiplyA(-4);
PrintMultiplyA(-5);

