// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите число A");
int number = Convert.ToInt32(Console.ReadLine());

int SummaNumber(int n)
{
    int rezult = 0;
    for (int i = 0; i <= n; i++)
    {
        rezult = rezult + i;

    }
    return rezult;

}
int summaNumber= SummaNumber(number);
if (number > 0)
    Console.WriteLine(summaNumber);
else   
    Console.WriteLine("Введите число A");