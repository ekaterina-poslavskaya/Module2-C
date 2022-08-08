// ДЗ. Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее
// 
Console.Write("Введите целое число а=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b=");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) {Console.Write($"Число а={a} больше числа b={b}; max={a}");}
else if (a<b) {Console.Write($"Число а={a} меньше числа b={b}; max={b}");}
else {Console.Write($"Числа а={a} и b={b} равны");}