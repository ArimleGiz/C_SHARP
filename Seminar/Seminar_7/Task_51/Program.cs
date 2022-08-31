/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
/*
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

void PrintDiagonalSum(int[,] arr)
{
    int min = Math.Min(arr.GetLength(0), arr.GetLength(1));

    int sumNum = 0;
    string sumStr = string.Empty;
    for (int i = 0; i < min; i++)
    {
        sumNum += arr[i, i];

        if (i != min - 1) sumStr += $"{arr[i, i]}+";
        else sumStr += $"{arr[i, i]}";
    }

    Console.WriteLine($"Сумма элементов главной диагонали: {sumStr} = {sumNum}");
}

int[,] matrix1 = CreateMatrix(7, 3, 0, 10);
PrintMatrix(matrix1);
PrintDiagonalSum(matrix1);

Console.WriteLine();
int[,] matrix2 = CreateMatrix(3, 7, 0, 10);
PrintMatrix(matrix2);
PrintDiagonalSum(matrix2);
*/
// Второй вариант
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int DiagonalMatrix(int[,] matrix)
{
    int result = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (row == column) result += matrix[row, column];
        }
    }
    return result;
}

int[,] matrix = CreateMatrix(3, 4, 0, 99);
PrintMatrix(matrix);
int diagonal = DiagonalMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на главной диагонале = {diagonal}");