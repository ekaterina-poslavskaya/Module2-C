/*
void Method1()
{
    Console.WriteLine("Автор...");
}

void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}

//Method2_1(count:4, msg:"Новый текст");

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        i++;

    }
    return result;
}
*\

string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

for (int i = 2; i<=10; i++)
{
    for (int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}");
    }
    Console.WriteLine();
}
*/
//==Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, Char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i=0; i<length; i++)
    {   
        if (text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/
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

PrintArray(arr);