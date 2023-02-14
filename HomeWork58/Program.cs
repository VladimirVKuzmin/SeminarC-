// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine();

if(columns != rows)
{
    Console.WriteLine("Число строк должно быть равным числу столбцов");
    return;
}

int[,] arrayA = GetArray(rows, columns, -10, 10);
int[,]arrayB = GetArray(rows, columns, -10, 10);

PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(SumMatrix(arrayA,arrayB));

int[,] SumMatrix(int[,]array1, int[,]array2)
{
    int[,]array3 = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
       for (int j = 0; j < array2.GetLength(1); j++)
       {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i,j] = array3[i,j] + array1[i,k] * array2[k,j];  
            }
       } 
    }
    return array3;
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


