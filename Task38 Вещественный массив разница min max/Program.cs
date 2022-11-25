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
        array[i] = rnd.NextDouble() * (max -min) + min;
    }
    return array;
}
void PrintArray(double[] array, string elem1, string elem2)//Метод вывода массива
{
    Console.Write(elem1);
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)}  ");
        else
            Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)}");
    }
    Console.Write(elem2);
}
double MaxElementArray(double[] array)// Метод нахождения максимального элемента массива
{
    double maxElementArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[0]) maxElementArray = array[i];
    }
return maxElementArray;
}
double MinElementArray(double[] array)// Метод нахождения минимального элемента массива
{
    double minElementArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[0]) minElementArray = array[i];
    }
return minElementArray;
}
double[] arr = CreateArrayRndDouble(sizeMass, minMass, maxMass);
double diffMaxMinElements = MaxElementArray(arr)-MinElementArray(arr);
PrintArray(arr, "[", "] ->  ");
Console.WriteLine(Math.Round(diffMaxMinElements,1, MidpointRounding.ToZero));
// using SistemGlobalization
// NumberFormatInfo numberFormatInfo = new numberFormatInfo() 
// {
//     NumberDecimalSeparator = ".",
// };