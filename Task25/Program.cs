// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int num1 = Convert.ToInt32(Console.ReadLine());
int Degree(int j, int n)
{

    int degree = 1;
    for (int i = 1; i <= n; i++)
    {
        degree = degree * j;
    }
    return degree;
}
if (num1<0)
Console.WriteLine("Введите натуральное число В");
else
Console.WriteLine($"Число {num} в натуральной степени {num1} = {Degree(num, num1)}");