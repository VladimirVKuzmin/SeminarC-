// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// через методы затруднился решить, но используя последний семинар, решил так

Console.Write("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекутся в точке: ({x};{y})");
}
else if (k1 == k2 && b1 == b2)
{
  Console.WriteLine("Прямые совпадают");
}
else
{
  Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
}

