// // Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8
// Console.Write("Введите число N:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= n)
// {
//     if (count % 2 == 0)

//         Console.Write($"{count}, ");
//     count++;
// }
Console.Write("Введите число N:  ");
int i = 2;
for (int n = Convert.ToInt32(Console.ReadLine()); i < n; i += 2)
{
    Console.Write(i + " ");
}