//Фибоначчи

double Fibonacci(int n)
{
    if (n == 0) return -1;
    else
    {
        if (n == 1 || n == 2) return 1;
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

//Console.WriteLine($"Fib {10} = {Fibonacci(10)}");
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"Fib {i} = {Fibonacci(i)}");
}