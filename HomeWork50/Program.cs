// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите колличество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов:  ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

Console.WriteLine("Введите номер в строке:  ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер в столбце:  ");
int j = Convert.ToInt32(Console.ReadLine());

ValueElementPosition(array, i, j);

if (ValueElementPosition(array, i, j))
{
    Console.WriteLine($"Искомый элемент есть, коородинаты (i = {i}, j = {j} -> {array[i,j]})");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
bool ValueElementPosition(int[,]arr, int a, int b)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(a == i && b == j)
            return true;
        }
    }
    return false;
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

