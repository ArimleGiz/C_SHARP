/*
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
 Набор данных                Частотный массив
  1, 2, 3                1 встречается 3 раза
  4, 6, 1                2 встречается 2 раз
  2, 1, 6                3 встречается 1 раз
                         4 встречается 1 раз
                         6 встречается 2 раза
*/
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            matrix[row, column] = new Random().Next(min, max+1);
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

int[] FlattenMatrix(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = matrix[i / matrix.GetLength(1), i % matrix.GetLength(1)];
    }
    return array;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void PrintFrequencies(int[] arr)
{
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == arr[i - 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{arr[i - 1]} встречается {count} раз");
            count = 1;
        }

        if (i == arr.Length - 1)
        {
            Console.WriteLine($"{arr[i]} встречается {count} раз");
        }
    }
}

int[,] matrix = CreateMatrix(3, 3, 1, 6);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = FlattenMatrix(matrix);

int[] sorted = SortArray(array);

Console.WriteLine();
PrintFrequencies(sorted);
