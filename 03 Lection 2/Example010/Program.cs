int[] array = {11, 21, 31, 4, 51, 61, 17, 18, 19};

int n = array.Length;
int find = 4;
int i = 0;
while (i < n)
    {
        if (array[i] == find)
            {Console.WriteLine(i);
            }
        i++;
    }