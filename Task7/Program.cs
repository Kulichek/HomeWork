//: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
      Console.WriteLine("Понедельник");
      break;
    case 2:
      Console.WriteLine("Вторник");
      break;
    case 3:
      Console.WriteLine("Среда");
      break;
    case 4:
      Console.WriteLine("четверг");
      break;
    case 5:
      Console.WriteLine("пятница");
      break;
    case 6:
      Console.WriteLine("суббота");
      break;
    case 7:
      Console.WriteLine("Воскресенье");
      break;        
}
if (num < 6)
{
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("выходной");
}