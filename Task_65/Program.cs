﻿// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Write("Введите число М: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> ");
NaturalNumber(m,n);

void NaturalNumber(int num, int num2)
{
    if (num < n)
    {
        if (num2 == num - 1) return;
        NaturalNumber(num, num2 - 1);
        Console.Write($"{num2} ");
    }
    else
    {

        if (num2 == num + 1) return;
        NaturalNumber(num, num2 + 1);
        Console.Write($"{num2} ");
    }
}

