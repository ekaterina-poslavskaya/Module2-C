/*
Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int CalcDigitsSum(int num)
{
 if (num<10) return num;
 else
   return num%10 + CalcDigitsSum(num/10);


}

Console.WriteLine(CalcDigitsSum(45353));