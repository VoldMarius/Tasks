// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число ");
int digit = Convert.ToInt32(Console.ReadLine());
int ThreeDig(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
if (digit < 100 && digit > 0)
    Console.WriteLine("третьей цифры нет");
else if (digit < 0)
{
    digit = -1 * digit;
    Console.WriteLine(ThreeDig(digit));
}
else
    Console.WriteLine(ThreeDig(digit));

