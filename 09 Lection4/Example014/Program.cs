
/*string[,] table = new string[2, 5];
table[1, 2] = "слово";
table[0, 0] = String.Empty;

for (int rows = 0; rows < 2; rows++)
{
    for (int col = 0; col < 5; col++)
    {
        Console.WriteLine($"-{table[rows, col]}-");
    }

}*/
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { Console.Write($"{matrix[i, j]} "); }
        Console.WriteLine();
    }
}
void Fill2DIntArray(int[,] matrix, int minValue = Int32.MinValue, int maxValue = Int32.MaxValue - 1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { matrix[i, j] = new Random().Next(minValue, maxValue + 1); }

    }
}


int[,] matrix = new int[3, 4];
Fill2DIntArray(matrix,1,10);
Print2DArray(matrix);