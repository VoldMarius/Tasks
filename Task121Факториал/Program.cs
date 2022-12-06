int factorial(int i)//Метод нахождения факториала
{
    int result;

    if (i == 1)
        return 1;
    result = factorial(i - 1) * i;
    return result;
}
void InputCorrection()//Метод рекурсивного вывода факториала с проверкой ввода
{
label1:
Console.WriteLine("Введите число: ");
try
{
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("{0}! = {1}", i, factorial(i));
}
catch (FormatException)
{
    Console.WriteLine("Некорректное число");
    goto label1;
}

Console.ReadLine();
}
InputCorrection();