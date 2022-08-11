void FillArray(int[] collection)
{
 int length = collection.Length;
 int index = 0;
 while (index < length)
 {
   collection[index]=new Random().Next(1, 10);
   index++;  
 }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int i = 0;
    int result = -1;

    while (i < collection.Length)
    {
        if (collection[i]==find)
            {
             result = i;
             break;  
            }
       i++; 
    }
    return result;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
array[7] = 4;
int pos = IndexOf(array, 4);
Console.WriteLine(pos);
