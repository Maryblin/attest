﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int Ackerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Ackerman(m - 1, 1);
            }
            else
            {
                return Ackerman(m - 1, Ackerman(m, n - 1));
            }
        }
        Console.Write($"Ackermann function {Ackerman(m, n)} ");
    }
}