/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число...");
int num = Convert.ToInt32(Console.ReadLine());
if ((Math.Abs(num)>=100)&&(Math.Abs(num) < 1000))
    {
     string num_str = num.ToString();   
     if (num>0)
       Console.WriteLine($"Вторая цифра числа {num}: {num_str[1]}");
      else 
       Console.WriteLine($"Вторая цифра числа {num}: {num_str[2]}"); 
    }
else Console.WriteLine($"Число {num} не трехзначное!");    