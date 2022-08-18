/*
Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int ReadData(string comm)
{
    Console.Write(comm);
    return Convert.ToInt32(Console.ReadLine());
}

int LocalPow(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
        result *= A;

    return result;
}

int A = ReadData("Основание степени...");
int B = ReadData("Показатель степени...");
if (B < 0)
{
    Console.WriteLine("Показатель степени должен быть > 0");
}
else
{
    Console.WriteLine($"{A} в степени {B} = {LocalPow(A, B)}");

}
