// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] matrix1 = new int[,]
{
    {2, 4},
    {3, 4}
};

int[,]matrix2 = new int[,]
{
    {3, 2},
    {3, 3}
};

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно умножить матрицы");
    return;
}

int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)

{
    int sum = 0;
    for (int k = 0; k < matrix1.GetLength(1); k++)
    {
        sum += matrix1[i, k] * matrix2[k, j];
        {
            result[i, j] = sum;
        }
    }
}
}
Console.WriteLine("Результат умножения матриц: ");

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + "");
    }
    Console.WriteLine();
}