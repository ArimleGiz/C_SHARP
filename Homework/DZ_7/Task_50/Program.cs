/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
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

void FindElement(int row, int column, int[,] arr)
{
    if (row < arr.GetLength(0) && column < arr.GetLength(1))       //Не забываем, что индексы начинаются с нуля
        Console.WriteLine($"Элемент индекса[{row},{column}] в данном массиве = {arr[row, column]}");
            else Console.WriteLine($"Элемента индекса[{row},{column}] в данном массиве нет ");
}

int[,] arr = CreateMatrix(4,3,0,9);
PrintMatrix(arr);
FindElement(1, 7, arr);
FindElement(2, 2, arr);