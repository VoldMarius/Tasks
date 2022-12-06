// Array.Sort(array);
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// вход
void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else {
            Console.WriteLine($"{num} встречается {count} раз.");
            count=1;
            num = arr[i];
        }
    }
    Console.WriteLine($"{num} встречается {count} раз.");
}
