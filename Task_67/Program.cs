// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());

// мое решение
/* SumNumber(m, 0);

void SumNumber(int num, int sum)
{
    
    if (num == 0)
    {
        
        Console.WriteLine(sum);
        return;
    }
    sum = sum + num % 10;
    SumNumber(num /= 10, sum);
} */

Console.WriteLine("Сумма цифр заданного числа равна: " + Summa(m));

int Summa(int n)
{
    if (n > 0) return n % 10 + Summa(n / 10);
    return 0;
}
