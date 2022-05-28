// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите: ");
int baseNum = int.Parse(Console.ReadLine());

// через цикл
int result = 0;
int d10 = 1;
while (num != 0)
{
    result += num % baseNum * d10;
    num /= baseNum;
    d10 *= 10;
}
Console.WriteLine(result);

// через рекурсию
void DecToOther(int n, int baseN)
{
    if (n == 0) return;
    DecToOther(n / baseN, baseN);
    Console.Write(n % baseN);
}

DecToOther(num, baseNum);

// string result = "";

//     for (int i = 0; i < num; i++)
//     {
//         result += $"{num % 2}";
//         num /= 2;
//     } 
// Console.WriteLine(result);
