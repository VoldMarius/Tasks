// Создайте метод ChangeColumns для обмена определенных столбцов матрицы
// размера 3 х 4 (порядковые номера столбцов вводятся).

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, -50, 50);
PrintMatrix(array2D);
// int[,] ChangeColumns(int[,] matrix, int j1, int j2)
// {
//     int[,] changeColumns = array2D;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int temp = 0;
//         int temp1 = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == j1)
//             {
//                 temp = matrix[i, j1];
//             }
//             if (j == j2)
//             {
//                 temp1 = matrix[i, j2];
//                 matrix[i, j2] = temp;
//                 matrix[i, j1] = temp1;
//             }
//         }
//     }
//     return changeColumns;
// }
Console.WriteLine();
PrintMatrix(ChangeColumns(array2D, 1, 2));
int[,] ChangeColumns(int[,] matrix, int colum1, int colum2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[i, j1];
        matrix[i, j1] = matrix[i, j2];
        matrix[i, j2] = temp;
    }
    return matrix;
}


