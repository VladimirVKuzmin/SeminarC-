// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number, remind, sum = 0, temp;
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
temp = number;
while (number > 0)
{
    remind = number % 10;
    number = number / 10;
    sum = sum * 10 + remind;
}
if (temp == sum)
   {
      Console.WriteLine("Число являеется палиндромом");
   }
   else
   {
      Console.WriteLine("Число не являеется палиндромом");
   }
