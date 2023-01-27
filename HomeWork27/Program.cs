// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine());
Sum(X);
void Sum(int number)
{
    int sum = 0;
    for (int i = 0; i < number; i++)
    {
    sum = sum + number % 10;
    number = number / 10;
    }
    
    Console.WriteLine($"Сумма цифр в числе {X} равна {sum}");
}