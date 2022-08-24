// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//     0, 7, 8, -2, -2    -> 2
//    -1, -7, 567, 89, 223-> 3

//Console.WriteLine("Задайте длину массива: ");
//int n;
//n = Convert.ToInt32(Console.ReadLine());
//int[] M = new int[n];
//Console.WriteLine("Введите числа: ");
//for (int i = 0; i < M.Length; i++)
//{
//    M[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Выбран  массив [" + string.Join(", ", M) + "]");  // применен String.Join Метод
//int count = 0;
//for (int i = 0; i < M.Length; i++)
//{
//    if (M[i] > 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Количество чисел больше нуля равно {count}");

// Исправленный вариант

void FillArray(int[] arrayCreate)
{
    Console.WriteLine("Введите числа:");
    for (int index = 0; index < arrayCreate.Length; index++)
    {
        arrayCreate[index] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

void WriteNumber(int[] array)
{
    Console.Write("Введен массив - [");
    for (var i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write(array[i]);
            Console.Write(", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.WriteLine("]");
}

Console.Write("Задайте длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[arrayLength];

FillArray(array1);

WriteNumber(array1);

int count = 0;
for (int i = 0; i < arrayLength; i++)
{
    if (array1[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше нуля равно {count}");