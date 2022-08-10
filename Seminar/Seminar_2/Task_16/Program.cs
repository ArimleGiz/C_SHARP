//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//  5, 25  ->  да
// -4, 16  ->  да
//  25, 5  ->  да
//   8, 9  ->  нет
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a * a == b || b * b == a) Console.WriteLine($"{a}; {b} -> да, одно из чисел является квадратом другого");
else Console.WriteLine($"{a}; {b} -> нет, ни одно из чисел не является квадратом другого");

//Второй вариант

//Console.Write("Введите первое число: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a * a == b || b * b == a)
//{
//    Console.WriteLine("Да");
//}
//else
//{
//    Console.WriteLine("Нет");
//}

//Пример 1: Возвести число в степень

// int a =2;
// int b = Convert.ToInt32(Math.Pow(a, 5)); // где 5-степень
// Console.WriteLine(b);

//Пример 2: Найти корень числа

// int a =81;
//int b = Convert.ToInt32(Math.Sqrt(a)); // 
// Console.WriteLine(b);

// Пример: Сгенерировать рандомное число от[-10; 10]
//new Random().Next(-10,11)

//Сгенерировать вещественное число от [0, 10.0]
// double n = new Random().NextDouble() * 10; // [0,10)

//от [-10,10]
// double n = new Random().NextDouble() * 20-10; 
//Console.WriteLine(n);

// [100.0, 150.0]
// double n = new Random().NextDouble() * 50+100; 
//Console.WriteLine(n);