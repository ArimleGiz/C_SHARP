// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2

Console.WriteLine("Зададим массив случайных (+) трехзначных чисел и покажем количество четных чисел");

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.Write($"Количество четных членов массива = {count}");
}

Console.Write("Введите длину желаемого массива ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(arrayLength);
PrintArray(myArray);
NumberOfEven(myArray);