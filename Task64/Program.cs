// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void NaturalNumbers(int num)
{
    Console.Write($"{num}, ");
    if (num == 1) return;
    NaturalNumbers(num - 1);
}
Console.Write("Веедите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.Write($"N = {number} -> 1");
}
else
{
    Console.Write($"N = {number} -> ");
    NaturalNumbers(number);
}
