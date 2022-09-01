//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
using System;
class Program
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Введите число столбцов");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число строк");
        int y = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[x, y];
        Console.WriteLine("Введите элементы массива");

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write("array[" + i + "," + j + "]: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine();

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{array[i, j]}{"\t"}");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
        Console.WriteLine("Введите координаты элемента для поиска через enter");
        int z = Convert.ToInt32(Console.ReadLine());
        int w = Convert.ToInt32(Console.ReadLine());
        if (x > z && y > w)
            Console.WriteLine($"{z}{w}{"такого числа нет"}");
        else
        {
            Console.WriteLine($"{z}{w}{"такое число есть"}");
        }
    }
}
