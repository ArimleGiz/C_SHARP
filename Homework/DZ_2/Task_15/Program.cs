// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да
//  7 -> да
//  1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели:");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay > 0 && numberDay < 8)
{
    if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine($"{numberDay} Да, это день выходной ;)");
    }
    else
    {
        Console.WriteLine($"{numberDay} нет, этот день рабочий:(");
    }
}
else
{
    Console.WriteLine($"{numberDay} Такого дня недели не существует");
}