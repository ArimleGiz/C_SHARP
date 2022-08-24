// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// Первый вариант решения

//Второй вариант
int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(1, 6);
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

int[] Multiplication(int[] arr)
{
    int len = arr.Length;
    int new_len = 0;
    if (len % 2 == 0) new_len = len / 2;
    else new_len = len / 2 + 1;
    int[] new_array = new int[new_len];

    for (int i = 0; i < new_len; i++)
    {
        new_array[i] = arr[i] * arr[len - 1 - i];
    }
    return new_array;
}
Console.Write("Введите желаемую длину массива в виде целого числа: ");
int len_array = Convert.ToInt32(Console.ReadLine());

int[] myarr = ArrayCreation(len_array);
PrintArray(myarr);
int[] new_array = Multiplication(myarr);
PrintArray(new_array);