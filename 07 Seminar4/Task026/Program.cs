/*
Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
void PrintResult(int a)
{
    Console.WriteLine($"В числе {a} количество цифр равно: {CountNumberDigitStr(a)} (через строки)");
    Console.WriteLine($"В числе {a} количество цифр равно: {CountNumberDigit(a)} (цикличный поиск)");

}

int CountNumberDigitStr(int a)
{
    int result = -1;
    int numberAbs = Convert.ToInt32(Math.Abs(a));
    //string numberStr = numberAbs.ToString();
    result = numberAbs.ToString().Length;
    return result;
}

int CountNumberDigit(int a)
{
    int result = 1;
    while (a / 10 != 0)
    {
        result++;
        a /= 10;
    }

    return result;
}

int number = Convert.ToInt32(Console.ReadLine());
PrintResult(number);