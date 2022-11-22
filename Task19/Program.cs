// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Первое решение:(По условию задачи "принимает на вход пятизначное число" )

// Console.Write("Введите пятизначное число:    ");
// int digit = Convert.ToInt32(Console.ReadLine());
// void Palindrome(int n)
// {
//     if (n < 100000 && n >= 10000)
//     {
//         if (n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10)
//         {
//             Console.Write("Число является палиндромом");
//         }
//         else
//             Console.Write("Число не является палиндромом");
//     }
//     else
//         Console.Write("Посчитайте цифры! Их должно быть пять! ");
// }
// Palindrome(digit);


// Второе решение:(для любого числа типа int)

// Console.Write("Введите любое число:    ");
// int digit = Convert.ToInt32(Console.ReadLine());
// int Palindrome(int n)
// {
//     if (n > 9)
//     {
//         string revers_n = (" ");
//         int remainder = 0;
//         while (n > 0)
//         {
//             remainder = n % 10;
//             n = n / 10;
//             revers_n = revers_n + remainder;
//         }
//         return (Convert.ToInt32(revers_n));
//     }
//     else
//         return 0;
// }
// Palindrome(digit);

// if (digit < 0)
// {
//     digit = digit * -1;
// }
// if (digit == Palindrome(digit))
// {
//     Console.Write("Число является палиндромом");
// }
// else if (digit < 10)
//     Console.Write("Единичное число заведомо является палиндромом");
// else if (digit < 0)
//     digit = digit * -1;
// else
//     Console.Write("Число не является палиндромом");


// Решение без строки
Console.Write("Введите любое число:    ");
int digit = Convert.ToInt32(Console.ReadLine());

int Palindrome(int n)
{
    if (n > 9)
    {
        int number_digit = 0;
        int revers_n = 0;
        for (int i = 0; n > 0; i++)
        {
            number_digit = n % 10;
            revers_n = (revers_n + number_digit) * 10;
            n = n / 10;

        }
        revers_n = revers_n / 10;
        return (revers_n);

    }
    return (0);
}
Palindrome(digit);
if (digit == Palindrome(digit))
{
    Console.Write("Число является палиндромом");
}
else if (digit < 10)
    Console.Write("Единичное число заведомо является палиндромом");
else if (digit < 0)
    digit = digit * -1;
else
    Console.Write("Число не является палиндромом");
