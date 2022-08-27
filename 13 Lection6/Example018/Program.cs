// в случайных точках консоли вывести случайные числа

Random R = new Random();

Console.CursorVisible = false;
int i = 0;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
while (i < 1000)
{
    Console.SetCursorPosition(
        left: R.Next(Console.WindowWidth),
        top: R.Next(Console.WindowHeight));

    Console.Write($"{R.Next(10)}\t");
    Thread.Sleep(10);

}
Console.ResetColor();