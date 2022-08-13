/*
Задача 21: Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
double VectorScalar(int xA, int yA, int xB, int yB)
{
 return Math.Sqrt(Math.Pow(xA-xB,2)+Math.Pow(yA-yB,2));

}

Console.WriteLine(VectorScalar(3,6,2,1).ToString());
Console.WriteLine(VectorScalar(7,-5,1,-1).ToString());