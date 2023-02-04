// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите проверяемое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine(" ]");
}

int PositivNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] >= 0)
        count++;
    }
    return count;
}

int result = 0;

Console.WriteLine("Введите количество проверяемых чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = GetArray(number);
PrintArray(newArray);
result = PositivNumbers(newArray);
Console.WriteLine($"Чисел больше нуля: {result}");
