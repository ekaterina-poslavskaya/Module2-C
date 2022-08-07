// Вывод последнией цифры 3х значного числа
Console.WriteLine("Введите число >=100 и <1000....");

int N = Convert.ToInt32(Console.ReadLine());
if ((N >= 100) && (N < 1000))
    {
        int r = N % 10;
        Console.WriteLine($"Последняя цифра равна...{r}");
    }
else  Console.WriteLine($"Некорректное число...{N}");       