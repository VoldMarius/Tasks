// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
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
int [] CopyArray(int[]array)
{int[]copyArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    copyArray[i]= array[i];
}
return copyArray;

}
Console.WriteLine("Введите длинну массива: ");
int sizeMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMass = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(sizeMass, minMass, maxMass);
PrintArray(arr, "[","] --> origin" );
PrintArray(CopyArray(arr), "[","] --> new");