
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29
int AkkermanFunction(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    if (a > 0 && b == 0)
    {
        return AkkermanFunction(a - 1, 1);
    }
    return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
}
Console.Write("Веедите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {AkkermanFunction(m, n)}");
