/*Задача 24: Напишите программу, которая принимает на вход число 
(А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
int SumA(int a)
{
    int result = 0;

    for (int i = 1; i <= a; i++)
        result += i;

    return result;
}

void PrintSumA(int a)
{
    Console.WriteLine($"Сумма чисел от 1 до {a} равна {SumA(a)}");

}

PrintSumA(7);
PrintSumA(8);

