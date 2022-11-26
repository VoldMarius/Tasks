// Задача 36: Задайте одномерный массив, заполненный
//  случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите длинну массива: ");
int sizeMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMass = Convert.ToInt32(Console.ReadLine());
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
int SummElementOddIndex(int[] array) //Метод нахождения суммы элементов, стоящих на нечётных позициях.
{
    int summElementOddIndex = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summElementOddIndex = summElementOddIndex + array[i];
    }
    return summElementOddIndex;
}
void NoteOdd(int[] array, string el1, string el2)// Метод вывода массива с помеченными нечетными элементами
{
    Console.Write(el1);
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            Console.Write($"{array[i]}* ");
        else if (i != array.Length - 1)
            Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1)
            Console.Write($"{array[i]}");
        else if (i == array.Length - 1 && i % 2 != 0)
            Console.Write($"{array[i]}");

    }
    Console.Write(el2);
}
int[] arr = CreateRandomArray(sizeMass, minMass, maxMass);
int summElements = SummElementOddIndex(arr);
Console.WriteLine();
NoteOdd(arr, "[", "] --> Сумма элементов, стоящих на нечётных позициях:  ");
Console.Write(summElements);