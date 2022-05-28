// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int result = 1;
int res = 0;
int sum = 0;

Console.Write($"{res} {result} ");

for (int i = 1; i < num - 1; i++)
{
    sum = res + result;
    res = result;
    result = sum;
    Console.Write($"{sum} ");
}



// int size = int.Parse(Console.ReadLine());
// int[] array = new int[size];
// int[] newArray = new int[size];
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 20);
// }
// for (int i = 0; i < array.Length; i++)
// {
//     newArray[i] = array[i];
// }
// Console.WriteLine($"{string.Join(' ', array)}");
// Console.WriteLine($"{string.Join(' ', newArray)}");
