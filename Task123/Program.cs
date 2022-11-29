// В массиве хранятся цены на 10 видов мороженого. С помощью датчика
// случайных чисел заполнить массив целыми значениями, лежащими в диапазоне
// от 3 до 20 включительно. Определить порядковый номер самого дорогого
// мороженого. 
Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
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
void PrintArray(int[] array, string elem1, string elem2)//Метод вывода массива

{
    Console.Write(elem1);
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]},");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write(elem2);
}
