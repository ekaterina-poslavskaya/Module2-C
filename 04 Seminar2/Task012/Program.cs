﻿/*
12. Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
*/
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 % num1 == 0) Console.WriteLine($"{num2} кратно {num1}");
else Console.WriteLine($"Остаток от деления {num2} на {num1} равен {num2 % num1}");