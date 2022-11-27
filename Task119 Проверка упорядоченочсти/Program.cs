// Задача 11. Задано пять произвольных целых чисел (элементы массива).
//  Определить, является ли их расположение в массиве упорядоченным 
//  (т.е. по возрастанию или по убыванию) или неупорядоченным.
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
int[] CloneArray(int[] array) //Метод клонироваие массива
{
    int[] cloneArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = cloneArray[i];
    }
    return cloneArray;

}
void SortArrayMinMax(int[] arrayS)// Метод сортировки массива от min к max
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
    // PrintArray(arrayS);
}
void SortArrayMaxMin(int[] arrayS)// Метод сортировки массива от max к min
{
    int temp;
    for (int i = 0; i < arrayS.Length - 1; i++)
    {
        for (int j = i + 1; j < arrayS.Length; j++)
        {
            if (arrayS[i] < arrayS[j])
            {

                temp = arrayS[i];
                arrayS[i] = arrayS[j];
                arrayS[j] = temp;
            }
        }
    }
    // PrintArray(arrayS);
}
bool СheckArrayOrder(int[] array, int[] cloneArray)//Метод сравнения массивов на равенство
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == cloneArray[i])
        {
            count++;
        }
    }
    if (count == array.Length)
    {
        return true;
    }
    return false;
}
bool СheckArrayOrder1(int[] array)//Метод проверки массива на упорядоченность
{
    int count = 0;
    int count1 = 0;
    for (int i = 1; i < array.Length; i++)
    {
      
        {
            if (array[i-1] <= array[i])
            {
                count++;
            }
            else count =0;
            if (array[i-1] >= array[i])
            {
                count1++;
            }
            else count =0;
        }
    }
    Console.Write($"{count},{count1}");
    if (count == array.Length-1| count1 == array.Length-1)
    {
        return true;
    }
    return false;

}
int[] arr = CreateRandomArray(sizeMass, minMass, maxMass);
PrintArray(arr, "[", "] ->  ");
string result = СheckArrayOrder1(arr) ? "Массив упорядоченный " : "Массив неупорядоченный";
Console.Write(result);
