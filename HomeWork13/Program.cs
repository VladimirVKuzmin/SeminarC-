// Вывести третью цифру заданного числа или сообщить, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра {ThirdDigit(number1)}");
}
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
            result = number % 10;
        }
        return result; 
    }
