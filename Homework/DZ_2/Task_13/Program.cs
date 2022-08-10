// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberP = Convert.ToString(number);

if (numberP.Length > 2)
{
    Console.WriteLine("третья цифра " + numberP[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
