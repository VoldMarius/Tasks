// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.WriteLine("Введите сторону тренировка x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону тренировка y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону тренировка z: ");
int z = Convert.ToInt32(Console.ReadLine());
bool FindTricle(int a, int b, int c)
{
     return a + b > c && c + a > b && c + b > a;
}
Console.WriteLine(FindTricle(x, y, z) ? "Треугольник существует" : "Треугольника нет");