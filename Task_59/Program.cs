// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] arr = GetArray(4,4);
PrintArray(arr);
var min = Min(arr);
Console.WriteLine($"Минимальное число = {min.min}, i = {min.row}, j = {min.col}");
Console.WriteLine();
System.Console.WriteLine("Удаляем строку и столбец, на пересечении которых расположен наименьший элемент.");
int[,] del = Remove(arr);
PrintArray(del);
Console.WriteLine();
Console.WriteLine("Как в условии задачи!");
Reverse(del);

int[,] GetArray(int a, int b)
{
int[,] array = new int[a,b];
Random rndNum = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rndNum.Next(10);
}
}
return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

(int row, int col, int min) Min(int[,] array)
{
    int min = 10; // Присвоено значение 10 для проверки.
    int indexI = 0;
    int indexJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    return (indexI, indexJ, min);
}

int[,] Remove(int[,] array)
{
    int lengthI = array.GetLength(0);
    int lengthJ = array.GetLength(1);

    var min = Min(array);
    
    int[,] delet = new int[lengthI - 1, lengthJ - 1];
    int irow = 0;
    int jcol = 0;

    for (int i = 0; i < lengthI; i++)
    {
        jcol = 0;
        if (i == min.row)
        {
            ++i;

        }
        for (int j = 0; j < lengthJ; j++)
        {

            if (j == min.col)
            {
                j++;
                delet[irow, jcol] = array[i, j];
            }
            else
            {
                delet[irow, jcol] = array[i, j];
            }
            jcol++;
        }
        irow++;

    }
    return delet;
}

void Reverse(int[,] array)
{
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                Console.Write($"{array[j, i]} ");
            }
            Console.WriteLine();
        }
    
}
