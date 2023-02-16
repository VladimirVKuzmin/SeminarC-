// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"M = {M}, N={N} -> A({M},{N}) = {AckermanFunction(M,N)} ");

int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  if (n == 0) return AckermanFunction(m - 1, 1);
  return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}