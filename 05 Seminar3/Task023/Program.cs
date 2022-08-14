/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
string AllNumCoub (int num)
{
 string result = "";
 if (num >= 0)
    {
      for (int i=0; i<=num; i++)
        result = result + (i*i*i).ToString() + " ";   
    }
 else
    { 
      for (int i=0; i>=num; i--)
          result = result + (i*i*i).ToString() + " ";
    }

 return result;   
}

Console.WriteLine("3: " + AllNumCoub(3));
Console.WriteLine("5: " + AllNumCoub(5));
Console.WriteLine("2: " + AllNumCoub(2));
Console.WriteLine("-6: " + AllNumCoub(-6));
Console.WriteLine("0: " + AllNumCoub(0));