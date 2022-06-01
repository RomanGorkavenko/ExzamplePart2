// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] GetArray(int a, int b)
{
    int[,] array = new int[a,b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int result = 0;
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) 
            {
                str += $"{array[i, j]} + ";
                result += array[i, j];
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    int n = str.Length - 2;
    str = str.Remove(n, 2);
    Console.WriteLine($"{str}= {result}"); 
}



int[,] arr = GetArray(5,5);
PrintArray(arr);
