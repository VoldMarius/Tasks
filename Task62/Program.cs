// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}{separatorElems}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(endRow);
    }
}
int[,] SpireMatrix(int[,] matrix)
{
    int[,] spireMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int random = 1;
    int heightLimit = spireMatrix.GetLength(0);
    int widthLimit = spireMatrix.GetLength(1);
    for (int spire = 0; spire < heightLimit; spire++)
    {
        for (int i = spire; i < heightLimit - spire; i++)
        {
            for (int j = spire; j < widthLimit - spire; j++)
            {
                if (i == spire & j == spire)
                {
                    for (j = spire; j < widthLimit - spire; j++)

                        spireMatrix[i, j] = random++;
                }
                else if (i == (heightLimit + (spire + 1)) - heightLimit & j == widthLimit - (spire + 1))
                {
                    for (i = (spire + 1); i < heightLimit - (spire + 1); i++)

                        spireMatrix[i, j] = random++;
                }
            }
        }

        for (int i = heightLimit - (spire + 1); i > (spire - 1); i--)
        {
            for (int j = widthLimit - (spire + 1); j > (spire - 1); j--)
            {
                if (i == heightLimit - (spire + 1) & j == widthLimit - (spire + 1))
                {
                    for (j = widthLimit - (spire + 1); j > spire; j--)

                        spireMatrix[i, j] = random++;
                }
                else if (j == spire & i < heightLimit - (spire + 1))
                {
                    for (i = heightLimit - (spire + 1); i > spire; i--)

                        spireMatrix[i, j] = random++;
                }
            }
        }
    }
    return spireMatrix;
}
int[,] matrixNew = new int[20,20];
int[,] newSpireMatrix = SpireMatrix(matrixNew);
PrintMatrix(newSpireMatrix, "", ",", "");