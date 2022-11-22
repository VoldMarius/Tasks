// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
Console.WriteLine("Введите число A");
int number = Convert.ToInt32(Console.ReadLine());

int SNumber(int n)
{
    int rezult = 1;
    for (int i = 1; i <= n; i++)
    {
        rezult = rezult * i;

    }
    return rezult;

}
int sNumber= SNumber(number);
if (number > 0)
    Console.WriteLine(sNumber);
else   
    Console.WriteLine("Введите число A");