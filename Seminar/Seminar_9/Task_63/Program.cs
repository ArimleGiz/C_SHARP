/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
void PrintNumbers(int n)
{
    if (n == 0) return;
    PrintNumbers(n - 1);
    Console.Write($"{n} ");
}
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbers(number);


