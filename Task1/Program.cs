// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


Console.WriteLine("Введите значение M ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N ");
int n = Convert.ToInt32(Console.ReadLine());



void NaturalNumbersInInterval(int n, int m)
{
    if (n > m || 1 > m || 1 > n)
    {
        return;
    }
    Console.Write($"{n} ");
    NaturalNumbersInInterval(n + 1, m);
}

NaturalNumbersInInterval(n, m);
{
    if (n < m || 1 > m || 1 > n)
    {
        return;
    }
    Console.Write($"{m} ");
    NaturalNumbersInInterval(m + 1, n);
    
}




