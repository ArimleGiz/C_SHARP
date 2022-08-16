// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//  A (3,6,8);    B (2,1,-7), -> 15,84
//  A (7,-5, 0);  B (1,-1,9)  -> 11,53

Console.WriteLine("Найдем расстояние между двумя точками в 3D пространстве: ");
Console.WriteLine();

Console.WriteLine("Введите координаты x1 первого числа ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты у1 первого числа: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z1 первого числа: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2 второго числа: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты у2 второго числа: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z2 второго числа: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double segment = Math.Sqrt((z2 - z1) * (z2 - z1) + (y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
segment = Math.Round(segment, 2);
Console.WriteLine($"Расстояние между точками равно: {segment}");


