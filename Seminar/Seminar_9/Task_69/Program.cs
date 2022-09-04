/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Power(int a, int b)
{
    if (b == 1) return a;
    if (b % 2 == 0) return Power(a * a, b / 2);
    return a * Power(a, b - 1);
}

Console.Write("Введите основание степени: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите показатель степени: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Power(a, b);
Console.WriteLine($"Результат равен {result}.");