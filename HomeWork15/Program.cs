﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >0 && num < 8)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Сегодня выходной");
    }
    else 
    {
        Console.WriteLine("Сегодня рабочий день");
    }
}
