/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
int[,] CreateMatrix(int rowCount, int columnCount,  int min, int max)
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
            Console.Write($"{arr[row, column]} \t");
        }
        Console.WriteLine();
    }
}
void FindArithmeticMean(int[,] arr)                   // Метод поиска среднего арифметического элементов в каждом столбце
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            average += arr[i,j];
        }
        Console.WriteLine($"Среднее значение элементов столбца {j} = {average/arr.GetLength(0)}");
    }
}
int[,] arr = CreateMatrix(4, 3, 0, 9);
PrintMatrix(arr);
FindArithmeticMean(arr);

