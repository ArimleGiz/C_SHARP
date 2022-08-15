//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//int FindQuarter(int x, int y)
//{
//   if (x > 0 && y > 0)
//       return 1;
//   else if (x < 0 && y > 0)

//       return 2;
//   else if (x < 0 && y < 0)
//       return 3;
//  else if (x > 0 && y < 0)
//       return 4;
//   return 0;
//}

//Console.WriteLine(FindQuarter(4, 7));
//Console.WriteLine(FindQuarter(-19, 7));
//Console.WriteLine(FindQuarter(-1, -3));
//Console.WriteLine(FindQuarter(4, -8));
//Console.WriteLine(FindQuarter(4, 0));

//Второй вариант с помощью команды void (функция ничего не возвращает)



void FindQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine($"Точка ({x}; {y};) находится в 1 четверти");
    else if (x < 0 && y > 0)
        Console.WriteLine("2 четверть");
    else if (x < 0 && y < 0)
        Console.WriteLine("3 четверть");
    else if (x > 0 && y < 0)
        Console.WriteLine("4 четверть");
    else
        Console.WriteLine($"Точка ({x}; {y};) находится на координатной оси");
}

FindQuarter(4, 7);
FindQuarter(-19, 7);
FindQuarter(-1, -3);
FindQuarter(4, -8);
FindQuarter(4, 0);