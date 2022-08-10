// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int num1 = new Random().Next(100, 1000);
int num2 = (num1 / 100) * 10 + num1 % 10;
Console.WriteLine($"{num1} -> {num2}");

// Второй вариант

//int number = new Random().Next(100, 1000);
//Console.WriteLine(number);
//int digit1 = number / 100;
//int digit2 = number % 10;
//int newdigit = digit1 * 10 + digit2;
//Console.WriteLine(newdigit);

// Третий вариант

//int number = new Random().Next(100, 1000);
//Console.WriteLine(number);
//string str_number = number.ToString();
//char digit1 = str_number[0];
//char digit3 = str_number[2];
//string new_str_number = digit1.ToString() + digit3.ToString();
//int new__number = Convert.ToInt32(new_str_number);
//Console.WriteLine(new__number);
