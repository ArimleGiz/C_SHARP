// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример:
// [3 7 22 2 78] -> 76

Console.WriteLine("Зададим массив вещественных чисел и найдем разницу между max и min элементов массива");

void CreateArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        index++;
    }
}

void PrintArray(double[] colArray)
{
    int count = colArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(colArray[position] + " ");
        position++;
    }
}

double[] array = { 3, 7, 22, 2, 78 }; ;
CreateArray(array);
PrintArray(array);

Array.Sort(array);

var min = array[0];
var max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)

        max = array[i];
}
Console.WriteLine();
Console.WriteLine($"Минимальное: {min}");
Console.WriteLine($"Максимальное: {max}");
Console.WriteLine($"Разница: {max - min}");
