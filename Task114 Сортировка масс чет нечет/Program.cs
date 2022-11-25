// Задан одномерный массив целых чисел. Образуйте из него два отсортированных 
// по возрастанию массива, содержащих четные 
// и нечетные числа. 
Console.Write("Введите число X- кол-во элементов массива  ");
int x = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[x];
void RandomArray(int[] array)//Метод обьявления массива случайными элементами
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 50);
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
// PrintArray(RemoveElement(arr, 5));

int[] EvenSortArray(int[] array) //Метод сортировки по чётному числу
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array = (RemoveElement(array, i));
            i = i - 1;
        }
    }
    return array;
}


int[] OddSortArray(int[] array) //Метод сортировки по нечётному числу
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

void SortArray(int[] arrayS)// Метод сортировки массива
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
    PrintArray(arrayS);
}

SortArray(EvenSortArray(arr));

SortArray(OddSortArray(arr));