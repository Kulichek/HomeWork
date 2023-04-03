// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int m = 5;
int n = 7;

double[,]array = new double[m,n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {array[i,j] = rnd.NextDouble();
    }

}

Console.WriteLine("Введите номер строки: ");
  int row = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите номер столбца");
  int column = Convert.ToInt32 (Console.ReadLine());

  if (row >= 0 && row < m && column >= 0 && column < n)
  {
    Console.WriteLine("Значение элемента[{0}, {1}]: {2}", row, column, array[row, column]);
  }
else
{
    Console.WriteLine("Элемент[{0}, {1}] отсутствуют в массиве", row, column);
}