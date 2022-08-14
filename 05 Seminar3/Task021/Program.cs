/*
Задача 21: Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
double VectorScalar2D(int xA, int yA, int xB, int yB)
{
 return Math.Sqrt(Math.Pow(xA-xB,2)+Math.Pow(yA-yB,2));

}

/*
Домашнее задание:
Задача 21

Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double VectorScalar3D(int xA, int yA, int zA, int xB, int yB, int zB)
{
 return Math.Round(Math.Sqrt(Math.Pow(xA-xB,2)+
                             Math.Pow(yA-yB,2)+
                             Math.Pow(zA-zB,2)), 2);

}

Console.WriteLine(VectorScalar3D(3,6,8,2,1,-7).ToString());
Console.WriteLine(VectorScalar3D(7,-5,0,1,-1,9).ToString());