// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] array = new int[10]; //массив из 10 случайных трехзначных чисел
Random random = new Random();
for(int i= 0; i < array.Length; i++  )
{
    array[i] = random.Next(100, 1000);
}
int count = 0;
foreach(int number in array)// количество четных элементов в массиве
{
    if (number % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Рандомный массив");
 foreach(int number in array)
 {
    Console.WriteLine(number + "");
 }
 Console.WriteLine("Количество четных чисел: " + count);
