/*
Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
string AllNumQuad (int num)
{
 string result = "";
 if (num >= 0)
    {
      for (int i=0; i<=num; i++)
        result = result + (i*i).ToString() + " ";   
    }
 else
    { 
      for (int i=0; i>=num; i--)
          result = result + (i*i).ToString() + " ";
    }

 return result;   
}

Console.WriteLine("5: " + AllNumQuad(5));
Console.WriteLine("2: " + AllNumQuad(2));
Console.WriteLine("-6: " + AllNumQuad(-6));
Console.WriteLine("0: " + AllNumQuad(0));
