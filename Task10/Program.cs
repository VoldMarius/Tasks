// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых 
// операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число:    ");
int digit = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)

{
    int rez = (num / 10) % 10;
    return rez;
}
if (digit < 999)
{
    int secondDig = SecondDigit(digit);
    Console.Write($"Вторая цифра --> {secondDig}");
}
else
    Console.Write("Вы ввели не то:    ");


