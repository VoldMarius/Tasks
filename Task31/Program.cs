// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] CreateRandomArray(int size, int min, int max)//Метод обьявления массива случайными элементами
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)//Метод вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]},");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SummaPositive(int[] array)
{
    int summaPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summaPositive = summaPositive + array[i];
    }
    return summaPositive;
}
int SummaNegative(int[] array)
{
    int summaNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summaNegative = summaNegative + array[i];
    }
    return summaNegative;
}
int[]arr = CreateRandomArray(12, -9, 9);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов:{SummaNegative(arr)}");
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов:{SummaPositive(arr)}");