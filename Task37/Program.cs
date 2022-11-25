
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] MultPairs(int[] array)

{
    int MultPairslength = array.Length / 2;
    if (array.Length % 2 != 0)
    {
        MultPairslength = array.Length / 2 + 1;
    }
    int[] MultPairs = new int[MultPairslength];
    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < MultPairslength; i++) MultPairs[i] = array[i] * array[array.Length - 1 - i];
    }
    else
    {
        for (int i = 0; i < MultPairslength; i++) MultPairs[i] = array[i] * array[array.Length - 1 - i];
        MultPairs[MultPairslength - 1] = array[array.Length - array.Length -1/ 2];
    }
    return MultPairs;
}
Console.WriteLine("Введите длинну массива: ");
int sizeMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int maxMass = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(sizeMass, minMass, maxMass);
PrintArray(arr, "[", "] -->");
PrintArray(MultPairs(arr), "", " ");