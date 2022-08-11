/*
11. Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
*/
int num = new Random().Next(100,1000);
Console.WriteLine(num);
int digit1 = num/100;
int digit2 = num % 10;
Console.WriteLine(" "+digit1.ToString()+digit2.ToString());
