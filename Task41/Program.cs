// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
int Promt (string message)
{
    System.Console.Write("Введите количество чисел: ");
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int [] Inputarray(int length)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите i + 1");
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}]) = {array[i]}");
    }
}
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int length = Promt("Введите количество элементов >");
int[] array;
array = Inputarray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0  -{CountPositiveNumbers(array)}");


