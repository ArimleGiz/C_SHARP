// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//Например:
//  4 -> 16 
// -3 -> 9 
// -7 -> 49
int Number = new int();
Console.WriteLine("Введите число: ");
Number = Convert.ToInt32(Console.ReadLine());

int result = (Number * Number);

Console.WriteLine($"Квадрат числа {Number} = {result}");
