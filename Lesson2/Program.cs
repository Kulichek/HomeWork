﻿// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i<=a; i++)
{
    Console.WriteLine(i*i + "\t");
}
