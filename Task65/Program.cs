// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
Console.Write("Веедите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int number, int number1)
{
    if (number > number1)
    {
        {

            NaturalNumbers(number - 1, number1);
            Console.Write($"{number} ");
        }
    }
    else if (number < number1)
    {
        {
            NaturalNumbers(number + 1, number1);
            Console.Write($"{number} ");
        }

    }
    else Console.Write($"{number1} ");
}
// NaturalNumbers(m, n);
// void NumbersMToN(int numb1, int numb2)
// {
//     if (numb1 > numb2)
//     {
//         Console.Write($"{numb1} ");
//         NumbersMToN(numb1 - 1, numb2);
//     }
//     else if (numb1 < numb2)
//     {
//         Console.Write($"{numb1} ");
//         NumbersMToN(numb1 + 1, numb2);
//     }
//     else
//     {
//         Console.Write($"{numb1} ");
//     }
// }
