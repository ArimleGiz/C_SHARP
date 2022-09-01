/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();
int[,,] CreateArrayThree(int p, int m, int n)
{
    Random random = new Random();
    int[,,] arr = new int[p, m, n];

    //int[] arr1 = new int[]
    for (int k = 0; k < p; k++)
    {
        for (int i = 0; i < m; i++)
        {

            for (int j = 0; j < n; j++)
            {
                arr[k, i, j] = random.Next(10, 100);
                int num = random.Next(10, 100);

                for (int f = 0; f <= j; f++)
                {
                    if (num == arr[k, i, f])
                    {
                        num = random.Next(10, 100);
                        f = -1;
                    }

                }
                arr[k, i, j] = num;

            }
        }
    }
    return arr;
}

void PrintArrayThree(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {

        Console.WriteLine();
        for (int i = 0; i < arr.GetLength(1); i++)
        {

            for (int j = 0; j < arr.GetLength(2); j++)
            {
                Console.Write(arr[k, i, j] + $"[{k},{i},{j}]  ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] arrRes = CreateArrayThree(2, 2, 2);
PrintArrayThree(arrRes);