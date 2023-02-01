// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(20);
PrintArray(arr);
Console.WriteLine(SumFind(arr));

int SumFind(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            sum = sum + array[i-1];
            Console.Write($"[{array[i-1]}]");
        }
    }
    return sum;
}

int[] GetRandomArray(int numbers)
{
    int[] result = new int[numbers];

    for (int i = 0; i < numbers; i++) 
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

