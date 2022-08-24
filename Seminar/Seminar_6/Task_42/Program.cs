// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 - > 101101
//  3  -> 11
//  2  -> 10


//Первый вариант решения через массив

int GetLenthArray(int number)
{
    int len = 0;
    while (number >= 1)
    {
        number = number / 2;
        len++;
    }
    return len;
}

int[] Converter(int number)
{
    int[] array = new int[GetLenthArray(number)];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = number % 2;
        number = number / 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] myArray = Converter(23);
PrintArray(myArray);

//Второй вариант через строку
//void MakeBinary()
//{
//   Console.Write("Введите натуральное число: ");
//   int number = Convert.ToInt32(Console.ReadLine());

//   string binary = string.Empty;
//   int n = number;
//   while (n > 0)
//   {
//       binary = $"{n % 2}" + binary;
//       n /= 2;
//   }

//  Console.WriteLine($"{number} -> {binary}");
//}

//MakeBinary();