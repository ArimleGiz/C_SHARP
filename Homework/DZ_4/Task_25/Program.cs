//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//   3, 5 -> 243 (3⁵)
//   2, 4 -> 16
Console.WriteLine("Введите числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberInPower = numberA;

for (int i = 1; i < numberB; i++)
{
    numberInPower = numberInPower * numberA;
}
Console.WriteLine(numberInPower);