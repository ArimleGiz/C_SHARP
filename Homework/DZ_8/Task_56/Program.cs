/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            matrix[row, column] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int GetRowMinSum(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[] array = new int[size];
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];

        }
    }
    minSum = array[0];
    foreach (var item in array)
    {
        Console.WriteLine(item + " ");
    }
    Console.WriteLine();
    for (int i = 1; i < size; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            minRow = i;
        }
    }
    return minRow;
}
int[,] matrix = CreateMatrix(4, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();

int result = GetRowMinSum(matrix);
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {result} строка ");