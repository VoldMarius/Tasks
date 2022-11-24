// Даны целочисленные массивы X и Y с разным количеством элементов. 
// Найти минимальные элементы этих массивах среди элементов, имеющих четный индекс.
Console.WriteLine("Введите число X- кол-во элементов 1-го массива  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y- кол-во элементов 2-го массива  ");
int y = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[x];
int[] arr1 = new int[y];
void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 50);
    }
}


RandomArray(arr);
RandomArray(arr1);

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
PrintArray(arr1);

int MinElement(int[] array)
{
    int length = array.Length - 1;
    int evenMinElement = array[0];

    {
        for (int i = 0; i < length; i = i + 2)
        {
            if (array[i] < array[0])
            {
                evenMinElement = array[i];
            }
        }
        return evenMinElement;
    }
}


int minElementX = MinElement(arr);
int minElementY = MinElement(arr1);
Console.Write($"Mинимальный чётный элемент массива с числом элементов Х = {minElementX}");
Console.WriteLine();
Console.Write($"Mинимальный чётный элемент массива с числом элементов Y = {minElementY}");
