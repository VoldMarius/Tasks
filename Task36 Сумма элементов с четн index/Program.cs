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
int[] arr = CreateRandomArray(sizeMass, minMass, maxMass);
int SumElementOddIndex(int[] array) //Метод нахождения суммы элементов, стоящих на нечётных позициях.
{
   
int sumElementOddIndex = 0;
    for (int i = 1; i < array.Length ; i += 2)
    {
        sumElementOddIndex = sumElementOddIndex + array[i];
    }
    return sumElementOddIndex;
}
int sumElements = SumElementOddIndex(arr);
PrintArray(arr, "[", "] ->  ");
Console.Write(sumElements);