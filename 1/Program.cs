// Блок 3. Выводит чётные элементы массива.

int[] arr = new int[] { 5, -5, 5, -3, 0, 4, 6, -222, 567, 342, -12, -1, 0 };
PrintArray(arr, "[", "]");
Console.WriteLine();
PrintArray(EvenElenentArray(arr), "[", "]");
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
int[] EvenElenentArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    int[] arrayEven = new int[count]; 
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)

        {
            arrayEven[j] = array[i];
            j++;
        }
    }
    return arrayEven;
}