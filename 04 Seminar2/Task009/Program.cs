/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа
*/
int num = new Random().Next(10, 100);
Console.WriteLine(num);
int digit1 = num / 10;
int digit2 = num % 10;
if (digit1>digit2)  Console.WriteLine(digit1);
else Console.WriteLine(digit2);