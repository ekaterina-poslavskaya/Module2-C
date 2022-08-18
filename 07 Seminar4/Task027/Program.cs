/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

void PrintResult(int a)
{
    Console.WriteLine($"Сумма цифр числа {a} равна: {SumNumberDigitStr(a)} (через строки)");
    Console.WriteLine($"Сумма цифр числа {a} равна: {SumNumberDigit(a)} (цикличный поиск)");

}

int SumNumberDigitStr(int a)
{
    int result = 0;
    int numberAbs = Convert.ToInt32(Math.Abs(a));
    string numberAbsStr = numberAbs.ToString();
    for (int i = 0; i < numberAbsStr.Length; i++)
    {
        //Console.WriteLine($"i={i};result={result}; a[i]={numberAbsStr[i]}; Char.GetNumericValue(numberAbsStr[i]) = {Char.GetNumericValue(numberAbsStr[i])}");
        result = result + Convert.ToInt32(Char.GetNumericValue(numberAbsStr[i]));
    }
    return result;
}

int SumNumberDigit(int a)
{
    int numberAbs = Convert.ToInt32(Math.Abs(a));
    int result = 0;
    if (numberAbs <= 9)
    { result += numberAbs % 10; }
    else
    //int result = numberAbs % 10;
    //if (numberAbs > 9)
    {
        while (numberAbs / 10 != 0)
        {
            result += numberAbs % 10;
            numberAbs /= 10;
        }
        result += numberAbs;
    }
    return result;
}

int number = Convert.ToInt32(Console.ReadLine());
PrintResult(number);
