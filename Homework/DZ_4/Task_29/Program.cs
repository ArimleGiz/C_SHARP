// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
//   1, 2, 5, 7, 19, 6, 1, 33  -> [1, 2,  5, 7, 19, 6, 1, 33]

Console.WriteLine("Зададим массив из 8 элементов, и выведем его на экран");
int[] array = new int[8];
for (int i = 0; i < 8; i++)

{
    Console.Write($"Введите {i + 1}-е целое число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Вывод массива");
for (int i = 0; i < 8; i++)
{
    Console.WriteLine(array[i]);
}