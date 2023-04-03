//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int m = 1;
int n = 3;



double[,]array = new double[m,n];// создаем двумерный массив
Random rnd = new Random(); //заполняем случайными числами
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = rnd.NextDouble();//генерируем число от 0 до 1
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i,j] + "");
    }
    Console.WriteLine();
} 
