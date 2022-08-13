/*
Задача 18: Напишите программу, которая по заданному 
номеру четверти, показывает диапазон возможных 
координат точек в этой четверти (x и y)
*/
void IntervalByNum(int numQ)
{
 if (numQ==1)
    {Console.WriteLine($"Для четверти {numQ} диапазон: x>0, y>0");}
 else if (numQ==2)
    {Console.WriteLine($"Для четверти {numQ} диапазон: x<0, y>0");}
 else if (numQ==3)
    {Console.WriteLine($"Для четверти {numQ} диапазон: x<0, y<0");}
 else if (numQ==4)
    {Console.WriteLine($"Для четверти {numQ} диапазон: x>0, y<0");}
 else Console.WriteLine($"Четверти с номером {numQ} в Декартовой системе координат не существует!");   
}

IntervalByNum(0);
IntervalByNum(1);
IntervalByNum(2);
IntervalByNum(3);
IntervalByNum(4);
IntervalByNum(-6);

