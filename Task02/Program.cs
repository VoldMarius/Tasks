// Напишите программу, которая на входе принимает два числа и выдает, какое число 
// больше, а какое меньше
// Например:
// a=5;b=7 -> max = 7
// a=2;b=10 -> max =10
// a=-9;b=-3 -> max = -3
Console.Write("Введите первое число:  ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num > num1)
    Console.Write($"max = {num}");
else
    Console.Write($"max = {num1}");