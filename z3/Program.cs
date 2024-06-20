// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System;
class Program
{
    static void Main()
    {
        int[] array = { 10, 3, 8, 25, 5, 0 };
        ReverseArray(array, array.Length - 1);
    }
    static void ReverseArray(int[] arr, int ind)
    {
        if (ind < 0)
        {
            return;
        }
        Console.Writeline(arr[ind]);
        ReverseArray(arr, ind - 1);
    }
}