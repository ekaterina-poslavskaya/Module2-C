// Задача 8: Напишите программу, которая на вход 
//     принимает число (N), а на выходе показывает 
//     все чётные числа от 1 до N.

Console.Write("Введите число больше 0, N=...");
int N  = Convert.ToInt32(Console.ReadLine());

if (N > 0)
    {
     int i = 2;
     while (i <= N)
        {
         Console.Write(i.ToString()+" ");   
         i=i+2;   
        }   
    }
else 
    {Console.WriteLine($"Число {N} меньше либо равно нулю. Выполнение программы невозможно.");}    
