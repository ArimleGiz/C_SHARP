// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//  [1 2 3 4 5] -> [5 4 3 2 1]
//  [6 7 3 6]   -> [6 3 7 6]

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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
void ReverseArray(int[] arr)
{
    //int length = arr.Length;
    for (int i = 0; i < arr.Length / 2; i++)    //for (int i = 0; i < length / 2; ++i)
    {
        //arr[i]<->arr[arr.Length-1-i]
        int temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
}
int[] arr = CreateArray(10, -5, 10);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
