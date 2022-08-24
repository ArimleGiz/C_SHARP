// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, 
// в массиве[3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

//int[] CreateArray(int length, int min, int max)
//{
//    int[] array = new int[length];
//    for (int i = 0; i < length; i++)
//    {
//        array[i] = new Random().Next(min, max + 1);
//    }
//    return array;
//}

//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write($"{array[i]} ");
//    }
//    Console.WriteLine();
//}

//int FindPositiveSum(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > 0) sum += array[i];
//    }
//   return sum;
//}

//int FindNegativeSum(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] < 0) sum += array[i];
//    }
//    return sum;
//}

//int[] array = CreateArray(12, -9, 9);
//PrintArray(array);
//Console.WriteLine($"Сумма положительных чисел равна {FindPositiveSum(array)}.");
//Console.WriteLine($"Сумма отрицательных чисел равна {FindNegativeSum(array)}.");

//Второй вариант
//метод, который инициализирует массив из 12 элементов в промежутке от [-9, 9]
int[] InitArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-9, 10); // [a,b)
    }

    return arr;
}

// метод, который считает сумму положительных чисел
int GetPositiveSummFromArray(int[] arr)
{
    int summ = 0;

    foreach (int item in arr)
    {
        if (item > 0)
            summ += item; // += это тоже самое, что и summ = summ + item;
    }

    return summ;
}

//метод, который считает сумму отрицательных чисел
int GetNegativeSummFromArray(int[] arr)
{
    int summ = 0;

    foreach (int item in arr)
    {
        if (item < 0)
            summ += item; // += это тоже самое, что и summ = summ + item;
    }

    return summ;
}

//метод, который печатает наш массив на консоль
void PrintArray(int[] arr)
{
    foreach (int item in arr)
        Console.Write($"{item} ");
}

//метод, который возвращает сумму положительных + сумму отрицательных
(int, int) GetSummsFromArray(int[] arr)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    foreach (int item in arr)
    {
        if (item > 0)
            positiveSumm += item;
        else
            negativeSumm += item;
    }

    return (positiveSumm, negativeSumm);
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив:");
PrintArray(arr);

int positiveSumm = GetPositiveSummFromArray(arr);
int negativeSumm = GetNegativeSummFromArray(arr);

Console.WriteLine();
Console.WriteLine($"Положительная сумма: {positiveSumm}. Отрицательная сумма: {negativeSumm}");

(positiveSumm, negativeSumm) = GetSummsFromArray(arr);
