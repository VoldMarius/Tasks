// // Виктор говорит:// Дан двумерный массив. Определить какие элементы повторяются в строке
// // // и вывести их в виде массива.

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) //3
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1)
//                 Console.Write($"{matrix[i, j],4}, ");
//             else Console.Write($"{matrix[i, j],4}");
//         }
//         Console.WriteLine("]");
//     }
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] DifferentElementsMatrixRows(int[,] matrix)
// {
    

//     int[] differentElementsMatrixRows = new int[matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == matrix[i, j - 1])
//                 differentElementsMatrixRows[i] = matrix[i, j];

//         }
//         return differentElementsMatrixRows;
//     }
//     return differentElementsMatrixRows;
// }
//     int[,] mat = CreateMatrixRndInt(5, 5, 1, 10);
//     PrintMatrix(mat);
//     int[] array = DifferentElementsMatrixRows(mat);
//     PrintArray(array);
// SOLID - это принципы разработки программного обеспечения, следуя которым 
// Вы получите хороший код, который в дальнейшем будет хорошо масштабироваться 
// и поддерживаться в рабочем состоянии.

// S - Single Responsibility Principle - принцип единственной ответственности. 
// Каждый класс должен иметь только одну зону ответственности.

// O - Open closed Principle - принцип открытости-закрытости.
//  Классы должны быть открыты для расширения, но закрыты для изменения.

// L - Liskov substitution Principle - принцип подстановки Барбары Лисков. 
// Должна быть возможность вместо базового (родительского) типа (класса) 
// подставить любой его подтип (класс-наследник), при этом работа программы не должна измениться.

// I -  Interface Segregation Principle - принцип разделения интерфейсов. 
// Данный принцип обозначает, что не нужно заставлять клиента (класс) реализовывать интерфейс,
//  который не имеет к нему отношения.

// D - Dependency Inversion Principle - принцип инверсии зависимостей. 
// Модули верхнего уровня не должны зависеть от модулей нижнего уровня.
//  И те, и другие должны зависеть от абстракции. Абстракции не должны зависеть от деталей.
//   Детали должны зависеть от абстракций.
int[,] NewRndMatrix(int rows, int columns, int minElement, int maxElement)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minElement, maxElement + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[] DifferentElementsMatrixRows(int[,] matrix)
{
    int[] ResultDifferentElementsMatrix = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++) // каждая строка
    {
        int elements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) // каждый элемент
        {
            for (int k = j+1; k < matrix.GetLength(0); k++) // каждый элемент, что правее
            {
                if (matrix[i, j] == matrix[i, k])
                    elements = matrix[i, j];
            }
        }
        ResultDifferentElementsMatrix[i] = elements;
    }
    return ResultDifferentElementsMatrix;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[,] matrix = NewRndMatrix(5, 5, 1, 10);
PrintMatrix(matrix);
int[] array = DifferentElementsMatrixRows(matrix);
PrintArray(array);