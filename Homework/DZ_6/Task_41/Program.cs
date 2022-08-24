// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//     0, 7, 8, -2, -2    -> 2
//    -1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте длину массива: ");
int n;
n = Convert.ToInt32(Console.ReadLine());
int[] M = new int[n];
Console.WriteLine("Введите числа: ");
for (int i = 0; i < M.Length; i++)
{
    M[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Выбран  массив [" + string.Join(", ", M) + "]");  // применен String.Join Метод
int count = 0;
for (int i = 0; i < M.Length; i++)
{
    if (M[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше нуля равно {count}");