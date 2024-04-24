// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Ack(int n,int m)
{
    if(n == 0)
    {
        return m + 1;
    }
    if(m == 0)
    {
        return Ack (n -1, 1);
    }
    return Ack(n - 1,Ack (n, m -1));
}





Console.WriteLine("Введите значение m ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n ");
int n = Convert.ToInt32(Console.ReadLine());

Ack(n,m);
Console.WriteLine(Ack(n,m));