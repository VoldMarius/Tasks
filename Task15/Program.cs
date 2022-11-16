// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите число от 1 до 7:  ");
int digit = Convert.ToInt32(Console.ReadLine());
bool Weekend(int n)
{
    return (n > 0 && n < 6);
}

if (digit > 7 || digit < 1)
Console.Write("Введите число от 1 до 7:  " );
else if (digit > 0 && digit < 8)
Console.Write(Weekend(digit) ? "Нет" : "Да");