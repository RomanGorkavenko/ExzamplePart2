// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = new int [size];
int [] copyArray = new int [size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(-10, 10);
    copyArray[i] = array[i];
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

foreach (int i in copyArray)
{
    Console.Write($"{i} ");
}
