// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//Результатом перемножения матриц А и B является матрица С , каждый элемент которой есть скалярное произведение 
//соответствующих строк матрицы A и столбцов матрицы B.
// Операция матричного умножения определена  для матриц, удовлетворяющих  условиям:
// Произведение AB определено, если число столбцов матрицы A совпадает с числом строк матрицы B.
//  (Другими словами, число элементов в строке матрицы  A  должно совпадать с числом элементов в столбце матрицы  B.)

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
int[,] MultiplicationTwoMatrices(int[,] matr, int[,] matr1)
{
    int[,] multiplicationMatrix = new int[matr.GetLength(0),matr1.GetLength(1)];
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                multiplicationMatrix[i, j] = 0;

                for (int k = 0; k < matr.GetLength(1); k++)
                    multiplicationMatrix[i, j] = matr[i, k] * matr1[k, j] + multiplicationMatrix[i, j];
            }
        }
    }
    return multiplicationMatrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("");
    }
}
int[,] matrix1 = CreateMatrixRndInt(5, 4, 2, 4);
int[,] matrix2 = CreateMatrixRndInt(4, 7, 2, 4);
Console.WriteLine(" Например, даны 2 матрицы:");
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1) != matrix2.GetLength(0))
    Console.WriteLine("Операция матричного умножения невозможна - число столбцов матрицы matrix1 не совпадает с числом строк матрицы matrix2");
else
{
    Console.WriteLine(" Результирующая матрица будет:");
    Console.WriteLine();
    int[,] matrixMultiplication = MultiplicationTwoMatrices(matrix1, matrix2);
    PrintMatrix(matrixMultiplication);
}
