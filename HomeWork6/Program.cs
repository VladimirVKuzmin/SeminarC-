// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
System.Console.WriteLine();
System.Console.Write("Введите число:    ");
string writeNumber = Console.ReadLine();
int number = Convert.ToInt32(writeNumber);
string result = $"Число {number} является чётным";

if (number % 2 != 0)
 result = result.Replace("является", "не является");

System.Console.WriteLine(result);
System.Console.WriteLine();