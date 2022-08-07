// Показываем все числа от -N до N
Console.Write("Введите число...");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(N);
int i = 0;
if (N > 0) {i = -N;}
if (N < 0) {i = N;}
Console.WriteLine(i);
while (i <= Math.Abs(N))
    {
      Console.Write(i);
      Console.Write(", ");  
      i++;  
    }
