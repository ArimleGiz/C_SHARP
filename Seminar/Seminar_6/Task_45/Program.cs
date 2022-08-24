// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.
int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0, 10000);
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
}

int[] CoppyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i]; // проверка один из способов newArr[i] = arr[i]*2;
    }
    return newArr;
}

int[] array = ArrayCreation(7);
Console.WriteLine();
// int [] newArray = CoppyArray(array);
int[] newArray = array;
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);
Console.WriteLine();
array[0] = 1;  // проверка что создали копию
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);