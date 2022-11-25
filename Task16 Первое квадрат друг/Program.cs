// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Введите число 1");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num1 = Convert.ToInt32(Console.ReadLine());
bool Sqv (int n, int n1)
{
return (n == n1*n1 || n1 == n*n);
}
Console.Write(Sqv (num, num1) ? "Да" : "Нет");