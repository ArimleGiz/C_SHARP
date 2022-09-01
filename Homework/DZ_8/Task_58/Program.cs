/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
void GreateMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintMatrix(int[,] matr)

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }

        }
    }
    return result;
}

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
Console.WriteLine($"Даны две матрицы:");
GreateMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
GreateMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine($"Результирующая матрица :");
int[,] result = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(result);

