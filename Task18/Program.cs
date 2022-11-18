// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти ");
int num1 = Convert.ToInt32(Console.ReadLine());

string Quarter(int num)
{
    if (num == 1) return "x > 0 и y > 0";
    if (num == 2) return "x < 0 и y > 0";
    if (num == 3) return "x < 0 и y < 0";
    if (num == 4) return "x > 0 и y < 0";
    return "Ввели не то число!";

}
Console.WriteLine(Quarter(num1));

