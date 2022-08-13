/*
17. Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер четверти плоскости, в которой находится эта точка.
*/
int FindQuater(int x, int y)
{
 if ((x>0)&&(y>0)) return 1;
 else if ((x<0)&&(y>0)) return 2;
 else if ((x<0)&&(y<0)) return 3;
 else if ((x>0)&&(y<0)) return 4;
 else return -1;    
}

Console.WriteLine(FindQuater(2,3));
Console.WriteLine(FindQuater(-2,3));
Console.WriteLine(FindQuater(-2,-3));
Console.WriteLine(FindQuater(2,-3));
Console.WriteLine(FindQuater(2,0));