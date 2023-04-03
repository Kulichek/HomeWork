// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 5;
int n = 7;

int[,] array = new int[m,n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = rnd.Next(1, 10);
    }
}


for (int j = 0;j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
{
    sum +=array[i,j];
}
double average = sum / m;
Console.WriteLine("Среднеарифмитический элемент {0}:{1}", j, average);
}