// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ");
    }
}
double[] FindArithmeticMeanElements(int[,] matrix)
{
    double[] findArithMeanElem = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ = summ + matrix[i, j];
        }
        findArithMeanElem[j] = summ / matrix.GetLength(0);
    }
    return findArithMeanElem;
}
void PrintArray(double[] arr)
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write("{0: 0.0};",arr[i]);
        else Console.Write("{0: 0.0}.",arr[i]);
    }
    Console.WriteLine("");
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
Console.WriteLine("Например, задан массив:");
PrintMatrix(array2D);
Console.Write("Среднее арифметическое каждого столбца:");
PrintArray(FindArithmeticMeanElements(array2D));
