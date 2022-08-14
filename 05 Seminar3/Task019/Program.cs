/*
Задача 19

Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
bool Polyndrome(int num)
{
 string num_str = num.ToString();
 if ((num_str[0]==num_str[4]) &&
    (num_str[1]==num_str[3]))
    return true;
 else return false;   
}

Console.Write("Введите пятизначное число....");
int num_abs = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if ((num_abs >= 10000) && (num_abs < 100000))
    {
    if (Polyndrome(num_abs)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
    }
else Console.WriteLine("Введено не пятизначное число");    