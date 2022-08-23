﻿/*
Задача 40: Напишите программу, которая принимает на вход три 
числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон.*/


using BasicArrFunc;
namespace Task040
{
    public class Task040
    {
        static void Main(string[] args)
        {
            int A = clsBasicArrFunc.ReadData("Введите длину стороны А...");
            int B = clsBasicArrFunc.ReadData("Введите длину стороны B...");
            int C = clsBasicArrFunc.ReadData("Введите длину стороны C...");

            if ((A < B + C) && (B < A + C) && (C < A + B))
                Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} существует!");
            else
                Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} НЕ существует!");
        }
    }

}