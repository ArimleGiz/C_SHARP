// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("В одномерном массиве из 123 чисел найдем количество элементов из отрезка [10,99]");
int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(1, 124);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int FindElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] myarr = ArrayCreation(123);
PrintArray(myarr);
int count = FindElements(myarr);
Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");


//Второй вариант

//Console.WriteLine("В одномерном массиве из 123 чисел найдем количество элементов из отрезка [10,99]");
//int [] array = new int [123];
//for (int i = 0; i < 123; i++)
//{
//    array [i] = new Random().Next(0,1000);
//    Console.Write($"{array [i]}  ");
//}
//int count = 0;
//for (int i = 0; i < 123; i++)
//{
//    if (array [i] >= 10 && array [i] <= 99 ) count = count + 1;
//}
//Console.WriteLine();
//Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");