// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

// корень квадратный (х2-х1, 2)+(у1 -у2, 2)+(z1-z2, 2)
Double x1, x2, x3, y1, y2, y3, z1, z2, z3, distance;
Console.WriteLine("Введите коорлинаты точки a: ");

Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x3: ");
x3 = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y3: ");
y3 = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите координаты z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z3: ");
z3 = Convert.ToDouble(Console.ReadLine());

// корень квадратный (х2-х1, 2)+(у1 -у2, 2)+(z1-z2, 2)

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine("Расстояние между точками равно: " + Math.Round(distance, 2));



