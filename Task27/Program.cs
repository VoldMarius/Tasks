// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int digit = Convert.ToInt32(Console.ReadLine());
int SummNum(int num)
{
    int summNum = 0;
    for (int i = 0; num > 0; i++)
    {
        summNum = summNum + num % 10;
        num = num / 10;
    }
    return summNum;
}
if (digit < 0)
{
    digit = -digit;
}
Console.WriteLine(SummNum(digit));
