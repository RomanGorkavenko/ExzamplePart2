// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());

if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num3)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");