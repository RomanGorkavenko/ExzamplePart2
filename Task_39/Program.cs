// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите целые числа через пробел: ");
int [] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int index1 = 0;
int index2 = arr.Length - 1;

while(index1 < index2)
{
    int temp = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = temp;

    index1++;
    index2--;
}

Console.WriteLine($"{String.Join(" ", arr)}");

Array.Reverse(arr);

Console.WriteLine($"{String.Join(" ", arr)}");
