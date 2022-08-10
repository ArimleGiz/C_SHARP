//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14->нет
// 46->нет
// 161->да

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"{num} -> да, число кратно одновременно 7 и 23");
else Console.WriteLine($"{num} -> нет, число не кратно одновременно 7 и 23");


//Второй вариант
//Console.Write("Введите первое целое число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number % 7 == 0 && number % 23 == 0) ;
//{
//   Console.WriteLine("Да");
//}
//else
//{
//   Console.WriteLine("Нет");
//}