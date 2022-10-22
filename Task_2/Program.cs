// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

Console.WriteLine("Введите номер первой поизиции элемента");
int first = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер второй позиции элемента");
int second = int.Parse(Console.ReadLine()!);

int[,] mass = Getarray(2, 5, 0, 10);
PrintArray(mass);
PrintElement(first, second, mass);

void PrintElement(int x, int y, int[,] array)
{
    if (x >= array.GetLength(0) || y >= array.GetLength(1)) Console.WriteLine($"В указанном массиве элемента с такими позициями нет");
    if (x < 0 || y < 0) Console.WriteLine("Номер позиции должен начинаться с нуля!");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (x == i && y == j) Console.WriteLine($"Элемент на позиции {x} и {y} равен {array[i, j]}");

            }
        }
    }

}

int[,] Getarray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|{Array[i, j]}|");
        }
        Console.WriteLine();
    }
}
