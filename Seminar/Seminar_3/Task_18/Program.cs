// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

//void FindRange(int number)
//{
//   if (number == 1)
//       Console.WriteLine("x > 0; y > 0");
//   else if (number == 2)
//       Console.WriteLine("x < 0; y > 0");
//   else if (number == 3)
//       Console.WriteLine("x < 0; y < 0");
//  else if (number == 4)
//      Console.WriteLine("x > 0; y < 0");
//  else
//     Console.WriteLine("Введите корректный номер четверти");
//}

//FindRange(1);
//FindRange(2);
//FindRange(3);
//FindRange(4);
//FindRange(0);

//Второй вариант решения
void Quarter(int number)
{
    if (number >= 1 && number <= 4)
        if (number == 1)
            Console.WriteLine("Это первая четверть и x > 0; y > 0");
        else if (number == 2)
            Console.WriteLine("Это вторая четверть и x < 0; y > 0");
        else if (number == 3)
            Console.WriteLine("Это третья четверть и x < 0; y < 0");
        else if (number == 4)
            Console.WriteLine("Это четвертая четверть и x > 0; y < 0");
        else
            Console.WriteLine("Не верно введен номер четверти");
}

Quarter(1);
Quarter(2);
Quarter(3);
Quarter(4);
Quarter(5);