
Console.WriteLine("Введите число(от 1 до4 )");
int a = Convert.ToInt32(Console.ReadLine());
switch(a)
{
case 1:
    Console.WriteLine("Диапазон значений от 0 до 90 градусов");
    break;
case 2:
    Console.WriteLine("Диапазон значений от 90 до 180 градусов");
    break;
case 3:
    Console.WriteLine("Диапазон значений от 180 до 270");
    break;
case 4:
    Console.WriteLine("Диапазон значений от 270 до 360");
    break;
    default:
    Console.WriteLine("Вы ввели не верное число");        
    break;
}