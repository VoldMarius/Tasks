// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число ");
int digit = Convert.ToInt32(Console.ReadLine());
int CountDig(int num)
{ 
    if (num >0)
{
    int i = 0;
    for (i = 0; num > 0; i++)

    {
        num = num / 10;
    }
    return i;
}
return 1;
}
if (digit <0)
{
    digit=-digit;
}
int countDig = CountDig(digit);
Console.WriteLine(CountDig(digit));
// Math.Abs();