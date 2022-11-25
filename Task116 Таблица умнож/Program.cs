// Напишите программу, которая выводит на консоль таблицу умножения.
// Реализовать через массив и метод 

int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
void Table(int[]arr)
{
for (int i = 0; i <arr.Length; i++)
{
    for (int j = 1; j <arr.Length; j++)
    {
        int rezult = i*j;
        Console.Write("{0}*{1}={2}\t",i,j,rezult);
    }
    Console.WriteLine();
}

}
Table(array);
