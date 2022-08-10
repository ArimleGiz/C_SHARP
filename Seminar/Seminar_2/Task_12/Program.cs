//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0) Console.WriteLine("Невозможно разделить на 0");
else if (num1 % num2 == 0) Console.WriteLine($"{num1}, {num2} -> кратно");
else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");

//Второй вариант

//int number1 = new Random().Next(10, 100);
//int number2 = new Random().Next(1, 10);
//Console.WriteLine(number1);
//Console.WriteLine(number2);
//if ((number1 % number2) == 0) ;
//Console.WriteLine("Кратно");
//else
//{
//   Console.Write("Не кратно. Остаток от деления:  ");
//   Console.WriteLine(number1 % number2);
//}

// Третий вариант

//int a = new Random().Next(10, 100);
//int b = new Random().Next(1, 10);
//if (a % b == 0) ;
//Console.WriteLine($"Число {a} кратно{b}");
//else
//{
//   Console.WriteLine($"Число {a} не кратно{b}. Остаток от деления");
//  Console.WriteLine(a % b);
//}