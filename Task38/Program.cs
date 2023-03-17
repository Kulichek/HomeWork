//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
double[] array = {3.14, 7.22, 2, 78}; //создали массив

double max = array[0]; //поиск минимального и максимального элементов массива
double min = array[0];

foreach (double number in array)
{
    if (number > max)
    {
        max = number;
    }
    if (number < min)
    {
        min = number;
    }
}
double diff = max - min; //считаем разницу между элементами
Console.WriteLine("Массив: ");
foreach (double number in array)
{
    Console.WriteLine(number + "");
}
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + diff);

