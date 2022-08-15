// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A(3, 6);  B(2, 1) -> 5,09
// A(7, -5); B(1, -1)-> 7,21

//double Distance(double x1, double y1, double x2, double y2)
//{
//    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
//   return dist;
//}
//double mydist = Distance(7, -5, 1, -1);
//Console.WriteLine(mydist);

// Второй вариант

double Distance(double[] A, double[] B)
{
    double distance = Math.Sqrt(Math.Pow(A[0] - B[0]), 2) + Math.Pow(A[1] - B[1], 2);
    Console.WriteLine("{0:N2}", distance);
    return distance;
}
Distance(new double[] { 3, 6 }, new double[] { 2, 1 });
Distance(new double[] { 7, -5 }, new double[] { 1, -1 });
