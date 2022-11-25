//  В заданном массиве действительных чисел найдите 
//  разность между максимальным и минимальным числом.
Console.Write("Введите число X- кол-во элементов массива  ");
int x = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[x];
void RandomArray(int[] array)//Метод обьявления массива случайными элементами
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
}
RandomArray(arr);

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

PrintArray(arr);
Console.WriteLine();
void MaxArray(int[] arrayM)// Метод сортировки массива
{
    int max = arrayM[0];
    for (int i = 1; i < arrayM.Length; i++)
    {

        if (arrayM[i] > arrayM[i-1])
        {
            max = arrayM[i];
        }
    }
Console.Write($"Максимальное элемент массива:{max}");
}
MaxArray(arr);



