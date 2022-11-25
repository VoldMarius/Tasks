// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
//  чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Реализация в упрощенном виде согласно условиям задачи:
Console.WriteLine("Введите длинну массива: ");
int sizeMass = Convert.ToInt32(Console.ReadLine());
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
int[] arr = CreateRandomArray(sizeMass, 100, 999);
int NumberEevenElements(int[] array)// Метод нахождения кол-ва  чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
PrintArray(arr, "[","] -->  ");
Console.Write(NumberEevenElements(arr)); 
Console.WriteLine();
Console.WriteLine("Ответ - использующий дополнительные методы для тренировки навыков исполнителя:");


//Реализация использующая дополнительные методы для тренировки навыков исполнителя

int[] EevenSortArray(int[] array) //Метод сортировки по чётному числу
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            array = (RemoveElement(array, i));
            i = i - 1;
        }
    }
    return array;
}
int[] RemoveElement(int[] arrayR, int index) //Метод удоления елемента массива по индексу
{
    int[] arrayNew = new int[arrayR.Length - 1];
    for (int i = 0; i < index; i++)
    {
        arrayNew[i] = arrayR[i];
    }
    for (int i = index + 1; i < arrayR.Length; i++)
    {
        arrayNew[i - 1] = arrayR[i];
    }
    arrayR = arrayNew;
    return arrayR;
}
int[]SortArray(int[] arrayS)// Метод сортировки массива по возрастанию
{
    int temp;
    for (int i = 0; i < arrayS.Length - 1; i++)
    {
        for (int j = i + 1; j < arrayS.Length; j++)
        {
            if (arrayS[i] > arrayS[j])
            {

                temp = arrayS[i];
                arrayS[i] = arrayS[j];
                arrayS[j] = temp;
            }
        }
            }
            return arrayS;
}
PrintArray(arr, "[",  "] -->  ");
PrintArray(SortArray(EevenSortArray(arr)), "[", "] -->");
Console.Write($"количество чётных чисел в массиве: {NumberEevenElements(arr)}");