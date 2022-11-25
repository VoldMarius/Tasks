// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
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
int[] arr = CreateRandomArray(4, -9, 9);

void ElementReplacement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}
PrintArray(arr, "[", "] -->  ");
ElementReplacement(arr);
PrintArray(arr, "[", "]");