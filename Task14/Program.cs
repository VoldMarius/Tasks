// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.Write("Введите число :  ");
int digit = Convert.ToInt32(Console.ReadLine());
bool Mult_city(int n)
{
    return (n % 7 == 0 && n % 23 == 0);
}
Console.Write(Mult_city(digit) ? "Да" : "Нет");
