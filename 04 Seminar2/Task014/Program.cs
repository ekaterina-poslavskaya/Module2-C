/*
14. Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
*/

int num = Convert.ToInt32(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0))
    Console.WriteLine($"{num} делится на 7 и на 23");
else Console.WriteLine($"{num} НЕ делится на 7 и на 23");