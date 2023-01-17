// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int[] Numbers = { 44, 5, 78 };

for (int i = 0; i < 3; i++)
{
    int max = Numbers[0];
    
    if (Numbers[i] > max)
    {
        max = Numbers[i];
        System.Console.WriteLine();
        System.Console.WriteLine($"Максимальное число {max}");
    }
}
System.Console.WriteLine();