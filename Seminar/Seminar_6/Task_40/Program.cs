// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

//Решение задачи с возвращением bool

bool CheckTriangleSides(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

void IsTriangle()
{
    int[] triangle = new int[3];
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите длину {i + 1}-й стороны: ");
        triangle[i] = Convert.ToInt32(Console.ReadLine());
    }

    if (CheckTriangleSides(triangle[0], triangle[1], triangle[2]))
    {
        Console.WriteLine($"Треугольник с длинами сторон {triangle[0]}, {triangle[1]} и {triangle[2]} существует.");
    }
    else Console.WriteLine($"Треугольник с длинами сторон {triangle[0]}, {triangle[1]} и {triangle[2]} НЕ существует!");
}
IsTriangle();

//Пример из bool
//boll ContainsNumber(int[]array,int number)
//{
//    foreach (int item in array)
//        if (item == number)
//            return false;
//}
//int[]arr=CreateArray(10,-5,10);
//PrintArray(arr);
//Console.WriteLine(ConstainsNumber(arr,7));

//Второй вариант
//int a = 3;
//int b = 4;
//int c = 15;

//if (a + b > c && a + c > b && b + c > a) ;
//Console.WriteLine("Такой треугольник ДА существует");
//else Console.WriteLine("Такой треугольник НЕ существует");

//Третий вариант -решение через функцию
//void Rectangle(int a, int b, int c);
//if (a + b > c && a + c > b && b + c > a)
//{
//    Console.WriteLine("Такой треугольник существует");
//};
//else
{
    Console.WriteLine("Такой треугольник не существует");
}
//Rectangle(3, 4, 4);