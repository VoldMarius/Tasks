// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите число 1");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num1 = Convert.ToInt32(Console.ReadLine());

bool Сompar(int n, int n1)
{
    return n % n1 == 0;

}
int Remainder(int n, int n1)
{
    return n % n1;
}

int remainder = Remainder(num, num1);
Console.WriteLine(remainder == 0 ? "Первое число кратно второму" : $"Некратно, остаток = {remainder}");
