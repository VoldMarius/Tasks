// Выполнить: Задан массив вещественных чисел (double) (10 элементов, сгенерированных случайным образом
//  в диапазоне от -5.0 до 5.0).
// 1. Создайте функцию для заполнения и вывода элементов массива.
// 2. Создайте еще одну функцию для подсчета и печати суммы троек рядом стоящих
//  элементов: a[1]+a[2]+a[3], a[2]+a[3]+a[4], a[3]+a[4]+a[5], …… , a[8]+a[9]+a[10].

// Указание 1: Для генерации случайных вещественных чисел используйте границы:
// // например, от -20 до 20:
// Random rand = new Random();
// a[i]=rand.NextDouble() * 40 - 20;
// Указание 2: Для вывода вещественных значений с указанием количества цифр после десятичной точки:
// две цифры после десятичной точки
// Write("{0:0.00} ",arr[i] ); // например 1.21

Console.WriteLine("Введите длинну массива: ");
int sizeMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxMass = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndDouble(int size, int min, int max)// Вывод вещественного массива:
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}
void PrintArray(double[] array, string elem1, string elem2)//Метод вывода массива
{
    Console.Write(elem1);
    for (int i = 0; i < array.Length; i++)
    {

        if (i != array.Length - 1)
            Console.Write($"{(Math.Round(array[i], 2, MidpointRounding.ToZero))}, ");
        else if (i == array.Length - 1)
            Console.Write($"{(Math.Round(array[i], 2, MidpointRounding.ToZero))}");

    }
    Console.Write(elem2);
}
double[] CountSumTriplElem(double[] array)
{
    double[] sumTriplElem = new double[array.Length - 2];
    for (int i = 0; i < sumTriplElem.Length; i++)
    {
        sumTriplElem[i] = array[i] + array[i + 1] + array[i + 2];
    }
    return sumTriplElem;
}
double[] arr = CreateArrayRndDouble(sizeMass, minMass, maxMass);
PrintArray(arr, "[", "]");
Console.WriteLine();
PrintArray(CountSumTriplElem(arr), "[", "]");