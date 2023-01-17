Console.WriteLine("введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int quadro1 = Quadro(num1);
int quadro2 = Quadro(num2);

if (quadro1 == num2 || quadro2 == num1)
{
Console.Write("Да");
}
else 
{
  Console.Write("Нет");  
}

int Quadro (int a)
{
    return a * a;
}