// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральноек число B");
int num1 = Convert.ToInt32(Console.ReadLine());
int DegreeNum(int j, int n)
{
    int degreeNum = 1;
    for (int i = 1; i <= n; i++)
    {
        degreeNum = degreeNum * j;
    }
    return degreeNum;
}
if (num1<0)
Console.WriteLine("Введите натуральное число В");
else
Console.WriteLine($"Число {num} в степени {num1} = {DegreeNum(num, num1)}");