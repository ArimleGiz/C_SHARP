// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

Console.WriteLine("Зададим массив и определим присутствует ли заданное число в массиве");
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10);
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


void FindNumber(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Массив содержит число {number}.");
            return;
        }
    }
    Console.WriteLine($"Массив  не содержит число {number}.");
}

int[] array = CreateArray(5, 0, 345);
int number = 5;
PrintArray(array);
FindNumber(number, array);
