// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
Console.WriteLine ("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
int numberA = a / 10000; // первая цифра
int numberB = (a / 1000) % 10; // вторая
int numberC = (a / 10) % 10; //четвертая
int numberD = a % 10; //пятая

if (numberA == numberD && numberB == numberC)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}
