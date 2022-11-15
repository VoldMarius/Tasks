// Написать программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от  -N до N 
// Например:
// 4 -> -4,-3,-2,-1,0,1,2,3,4
// 2 -> -2,-1,0,1,2

Console.Write("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while (count <= n)
{
    Console.WriteLine(count);
    count++;
}