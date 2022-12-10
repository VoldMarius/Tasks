// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

int SunOfNumbers(int number)
{
    int result = 0;
    if (number > 0)
    {
        result = number % 10;
        return result + SunOfNumbers(number /10);
    }
    else return 0;
}

int result = SunOfNumbers(num1);
Console.WriteLine(result);
