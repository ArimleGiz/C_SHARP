// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//  4-> 24
//  5-> 120
int Factorial(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

void PrintFactorial(int number)
{
    Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}.");
}

PrintFactorial(4);
PrintFactorial(5);
PrintFactorial(0);