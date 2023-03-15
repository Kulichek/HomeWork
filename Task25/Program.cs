//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16


    Console.Write("Введите число А: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число В: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = 1;
    for(int i = 0; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine("{0} в степени {1} равно {2}", a, b, result);

