int[] arr = {1, 5, 4, 3, 2,6,7,1,1};

void PrintArray(int[] array)
{   
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPos = i;

        for (int j = i+1; j<array.Length; i++)
        {
            if (array[j]<array[minPos]) minPos = j;
        }

        int tmp = array[i];
        array[i] = array[minPos];
        array[minPos] = tmp;
    }
}

void SelectionReverseSort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int maxPos = i;

        for (int j = i+1; j<array.Length; i++)
        {
            if (array[j]>array[maxPos]) maxPos = j;
        }

        int tmp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = tmp;
    }
}

PrintArray(arr);
SelectionSort(arr);