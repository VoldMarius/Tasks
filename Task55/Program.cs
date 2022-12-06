// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
int[,] SwapRowsColumns(int[,] matrix)
{
    int[,] temp = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j, i] = matrix[i, j];
        }
    }
    return temp;
}

void Output(int[,] matrix)
{
    if (matrix.GetLength(1) == matrix.GetLength(0))
    {
        int[,] swapedArray = SwapRowsColumns(matrix);
        PrintMatrix(swapedArray);
    }
    else
    {
        Console.WriteLine("\nМассив не квадратный, процедура не выполнима.");
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, -50, 50);
PrintMatrix(array2D);
Console.WriteLine();
Output(array2D);
