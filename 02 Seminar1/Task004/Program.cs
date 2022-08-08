// Задача 4: Напишите программу, 
//      которая принимает на вход три числа и 
//      выдаёт максимальное из этих чисел.

Console.Write("Введите целое число а=");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b=");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число c=");
int c = Convert.ToInt32(Console.ReadLine());

if (b > max) {max = b;}
if (c > max) {max = c;}

Console.WriteLine($"Максимальное число равно {max}");
