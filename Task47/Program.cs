// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.WriteLine("Введите число чтрок массива m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное знчение массива min:  ");
double minNumb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимальное знчение массива max:  ");
double maxNumb = Convert.ToDouble(Console.ReadLine());
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

double[,] array2D = CreateMatrixRndInt(m, n, minNumb, maxNumb);
PrintMatrix(array2D);
