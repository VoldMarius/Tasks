// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое число:  ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число:  ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num;

if (num1 > num)
    max = num1;
else if (num2 > num)
    max = num2;
Console.Write(max);