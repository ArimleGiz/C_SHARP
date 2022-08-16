// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//  7 -> 28
//  4 -> 10
//  8 -> 36

//int Sum(int a)
//{
//   int result = 0;
//   for (int number = 0; number <= a; number++) 
//   {
//      result += number;  //result=result+number;
//  }
//   return result;
//}
//Console.WriteLine(Sum(5));  //1+2+3+4+5=15
//Console.WriteLine(Sum(10));
//Console.WriteLine(Sum(0));
//Console.WriteLine(Sum(-20));

// Второй вариант(улучшенный)

int Sum(int a)
{
    int result = 0;
    for (int number = 0; number <= a; number++)
    {
        result += number;
    }
    return result;
}

void PrintSum(int a)
{
    Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");
}

PrintSum(5);  //1+2+3+4+5=15
PrintSum(10);
PrintSum(0);
PrintSum(-20);
