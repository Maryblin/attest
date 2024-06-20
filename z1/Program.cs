// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        NatNumber(m, n);
    }
    static void NatNumber(int m, int n)
    {

        if (m <= n)
        {
            Console.Write($"{m}  ");
            NatNumber(m + 1, n);
        }
    }
}