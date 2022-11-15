// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);


int DeliteSecondDig(int num)
{
    int b = num % 10;
    int a = num / 100 * 10 + b;
    return a;
}
int delSecDig = DeliteSecondDig(number);
Console.WriteLine($"число = {number} --> {delSecDig}");
