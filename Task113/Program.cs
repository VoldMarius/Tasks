// Дан одномерный массив чисел, в котором есть положительные, 
// отрицательные и нулевые элементы. Вычислить среднее арифметическое положительных элементов, 
// значение которых больше К и заменить им первый элемент массива.
Console.WriteLine("Введите число X- кол-во элементов массива  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число K  ");
int k = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[x];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-50, 50);
    }
}
RandomArray(arr);

void PrintArray(int[] array)
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

PrintArray(arr);

int ArithmeticMean(int[] array)
{
    int arithmeticMean = 0;
    int length = array.Length;
    int count = 0;
    int summElement = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0 && array[i] > k)
        {
            summElement = summElement + array[i];
            count++;
        }
        arithmeticMean = Convert.ToInt32(summElement / count);
    }
    return arithmeticMean;
}




// int[] arr1 = PrintArray(arr);
arr[0]=ArithmeticMean(arr);
Console.WriteLine(arr[0]);
PrintArray(arr);