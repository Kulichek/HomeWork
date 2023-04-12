//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

//задача 65. задайте значения М и Н. напишите программу, которая выведет все натуральные числа в промежутке от м до н

//Console.WriteLine("Введите число m: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ввелите число n: ");
//int n = Convert.ToInt32(Console.ReadLine());


int SumNumbers (int start, int end)
{
   if (start > end)
   {
    return 0;
   } 
   else 
   {
    return start + SumNumbers (start + 1, end);
   }
}
    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = SumNumbers(m, n);
     Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {sum}"); 


