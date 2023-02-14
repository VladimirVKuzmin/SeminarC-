// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()!);
int[,] arr = GetArray(rows, columns, 1, 10);

PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {SumRows(arr)}");

int SumRows(int[,] arr)
{
    int minrow = 0;
    int minsum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minsum += arr[0, i];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            minrow = i+1;
        }
    }
    return minrow;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 20);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


