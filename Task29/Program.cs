﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] array = new int[5] {4, 5, 6, 7, 8};

for(int i = 0; i < array.Length; i++ )
{
    Console.Write(array[i] + " ");
}