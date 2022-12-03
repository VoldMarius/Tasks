// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

double[,] CreateMatrixRndInt(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" ");
            if (matrix[i, j] < 0 && j != matrix.GetLength(1) - 1)
                Console.Write("{0: 0.00};", matrix[i, j]);
            else if (j == matrix.GetLength(1) - 1)
                Console.Write("{0: 0.00}", matrix[i, j]);
            else if (matrix[i, j] > 0 && j != matrix.GetLength(1) - 1)
                Console.Write(" {0: 0.00};", matrix[i, j]);
        }
        Console.WriteLine(" ");
    }
}
bool FindElementByIndex(double[,] matrix, int x, int y)
{

    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
        return true;
    else
        return false;

}
double[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);

Console.WriteLine("Введите  (позицию элемента в двумерном массиве) число(index)i:  ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  (позицию элемента в двумерном массиве) число(index)j:  ");
int j = Convert.ToInt32(Console.ReadLine());

while (i < 0 || j < 0)
{
    Console.WriteLine($"{i}{j}-->  индекс не может быть отрицательным");
    Console.WriteLine("Введите  (позицию элемента в двумерном массиве) число(index)i:  ");
    i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите  (позицию элемента в двумерном массиве) число(index)j:  ");
    j = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(FindElementByIndex(array2D, i, j) ? $"Элемент {i}{j}-->такое число в массиве есть"
                            : $"{i}{j}-->такого числа в массиве нет");