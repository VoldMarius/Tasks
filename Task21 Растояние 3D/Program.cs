// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты 1 точки ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты 2 точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());


double Distance(int xc, int xc1, int yc, int yc1, int zc, int zc1)
{
    double dist = Math.Sqrt((xc1 - xc) * (xc1 - xc) + (yc1 - yc) * (yc1 - yc) + (zc1 - zc) * (zc1 - zc));
    double res = Math.Round(dist, 2, MidpointRounding.ToZero);
    return res;
}

Console.WriteLine(Distance(x, x1, y, y1, z, z1));