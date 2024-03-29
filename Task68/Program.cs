﻿//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
// функция аккурмана- принимает 2 не отрицательных числа в качестве параметров и возвращает натуральное число.
int Akkerman(int m, int n)
{
    if (m == 0)
    return n + 1;
    else if (n == 0)
    return Akkerman(m - 1,1);
    else
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Akkerman(m, n);
Console.WriteLine($"Результат вычесления функции Аккермана для M = {m} и N = {n} равен {result}");