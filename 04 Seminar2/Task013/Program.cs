/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.Write("Введите число...");
int num = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(num)>=100)
    {
     string num_str = Math.Abs(num).ToString();   
     Console.WriteLine($"Третья цифра числа {num}: {num_str[2]}");      
    }
else Console.WriteLine($"Число {num} содержит менее 3 цифр!");     