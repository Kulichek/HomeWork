﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// А(3,6);В(2,1)->5,09
//A(7,-5); B(1,-1)->7,21
Double x1, x2, y1, y2, distance;
Console.WriteLine("Расстояние между двумя точками на плоскости");
Console.WriteLine("Введите координаты точки а: ");

Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ведите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Расстояние между точками равно: " + Math.Round(distance, 2));


