// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void number(int m, int n)
{
    if (m > n) return;
    {
        Console.Write($"{m}  ");
    }
    number(m + 1, n);
}
number(m, n);