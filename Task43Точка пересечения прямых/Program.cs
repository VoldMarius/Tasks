// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindXY(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1 )/ (k1 - k2 )+ b1;
    double[] array = new double[2];
    array[0]=x;
    array[1]=y;
    return array;
}
void PrintArray(double[] array, string elem1, string elem2)
{
    Console.Write(elem1);
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{Math.Round((array[i]), 1, MidpointRounding.ToZero)}; ");
        else
            Console.Write($"{Math.Round((array[i]), 1, MidpointRounding.ToZero)}");
    }
    Console.Write(elem2);
}
Console.WriteLine("Введите значение переменной b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double[]arr= FindXY(b1, b2, k1, k2);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -->  ");
 PrintArray(arr, "(", ")");