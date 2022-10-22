// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = Getarray(6, 8, -3, 10);
PrintArray (array);
AvrColSum (array);

void AvrColSum(int[,] array)
{
    double sum = 0;
    double average = 0;
    Console.Write ("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            if (i == array.GetLength (0) - 1)
            {
                average = sum/array.GetLength (0);
                Console.Write ($"{average:f1}; ");
                sum = 0;
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
            Console.Write($"| {Array[i, j]} |");
        }
        Console.WriteLine();
    }
}