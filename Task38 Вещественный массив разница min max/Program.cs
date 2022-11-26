// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
Console.WriteLine("Введите длинну массива: ");
int sizeMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMass = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndDouble(int size, int min, int max)// Вывод вещественного массива:
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}
void NoteMaxMin(double[] array, double max, double min, string el1, string el2)// Метод вывода массива с помеченными нечетными элементами
{
    Console.Write(el1);
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == min || array[i] == max)
            Console.Write($"{(Math.Round(array[i], 1, MidpointRounding.ToZero))}* ");
        else if (i != array.Length - 1)
            Console.Write($"{(Math.Round(array[i], 1, MidpointRounding.ToZero))}, ");
        else if (i == array.Length - 1)
            Console.Write($"{(Math.Round(array[i], 1, MidpointRounding.ToZero))}");
       
    }
    Console.Write(el2);
}
double MaxElementArray(double[] array)// Метод нахождения максимального элемента массива
{
    double maxElementArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElementArray) maxElementArray = array[i];
    }
    return maxElementArray;
}
double MinElementArray(double[] array)// Метод нахождения минимального элемента массива
{
    double minElementArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElementArray) minElementArray = array[i];
    }
    return minElementArray;
}
double[] arr = CreateArrayRndDouble(sizeMass, minMass, maxMass);
double diffMaxMinElements = MaxElementArray(arr) - MinElementArray(arr);
NoteMaxMin(arr, MaxElementArray(arr),MinElementArray(arr),"[","] ->   ");
Console.WriteLine(Math.Round(diffMaxMinElements, 1, MidpointRounding.ToZero));
Console.WriteLine($"Максимальный элемент массива:   {(Math.Round(MaxElementArray(arr), 1, MidpointRounding.ToZero))}*");
Console.WriteLine($"Минимальный элемент массива:    {(Math.Round(MinElementArray(arr), 1, MidpointRounding.ToZero))}*");
