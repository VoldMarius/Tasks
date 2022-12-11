// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Веедите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int SummaNaturalNumbers(int number1, int number2)
{
    int summaNaturalNumbers = number2;
    if (number1 > number2)
        summaNaturalNumbers = SummaNaturalNumbers(number1 - 1, number2) + number1;

    else if (number1 < number2)
        summaNaturalNumbers = SummaNaturalNumbers(number1 + 1, number2) + number1;

return summaNaturalNumbers;
}
int numNegativ = 0;
int Summ = SummaNaturalNumbers(num1, num2);

if (num1 < 0 && num2 > 0)
    Summ = SummaNaturalNumbers(numNegativ, num2);
else if (num1 > 0 && num2 < 0)
    Summ = SummaNaturalNumbers(num1, numNegativ);
else if (num1 < 0 && num2 < 0)
    Summ = SummaNaturalNumbers(numNegativ, numNegativ);


Console.Write($"M = {num1}; N = {num2}. -> {Summ} ");
