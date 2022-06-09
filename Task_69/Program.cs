// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 


// мое решение
/* int a = 2;
int b = 10;

DegreeNumber(a,b,1);

void DegreeNumber(int numberA, int numberB, int multiply)
{
    if (numberB == 0)
    {
        Console.WriteLine(multiply);
        return;
    }
    multiply *= numberA;
    DegreeNumber(numberA, numberB - 1, multiply);
} */

Console.Write("Введите число М: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"\n{a} в степни {b} равно: {Pow(a, b)}\n");

int Pow(int a, int pow)
{
    return pow == 0 ? 1 : Pow(a, pow - 1) * a;
}