// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример: 
//  [3, 7, 23, 12]  -> 19
//  [-4, -6, 89, 6] -> 0

Console.WriteLine("Зададим одномерный массив и найдем сумму элементов на нечетных позициях");
int[] CreateArray(int[] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        newArray[i] = new Random().Next(-100, 100);
    }
    return newArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetSummOfOddPositions(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.GetLength(0); i = i + 2)     // array[0] - четный элемент, array[1] - нечетный элемент
    {
        summ = summ + array[i];
    }
    return summ;
}

Console.Write("Задайте длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[arrayLength];

CreateArray(newArray);
Console.Write("Задан массив ");
PrintArray(newArray);
Console.Write($"Сумма чисел на нечетных позициях равна {GetSummOfOddPositions(newArray)}");
