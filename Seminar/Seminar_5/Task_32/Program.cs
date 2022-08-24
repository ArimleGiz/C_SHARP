// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.WriteLine("Зададим массив и заменим (+) на (-) и наоборот");
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine();
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


void FindReverseArray(int[] arr)                //int[]FindReverseArray([]array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i] * (-1)}");     //array[i]=array[i]*-1;
    }
    Console.WriteLine();                      //return array;
}

int[] array = CreateArray(4, -10, 10);
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Преобразованный массив:");
FindReverseArray(array);

