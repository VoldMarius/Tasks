// Задача 003:
// Написать программу которая будет выдавать
// название дня недели по заданному номеру
// Например:
// 3 -> Среда
// 5 -> Пятница
Console.Write("Введите Номер дня недели:  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
    Console.Write("Понидельник");
else if (num == 2)
    Console.Write("Вторник");
else if (num == 3)
    Console.Write("Среда");
else if (num == 4)
    Console.Write("Четверг");
else if (num == 5)
    Console.Write("Пятница");
else if (num == 6)
    Console.Write("Суббота");
else if (num == 7)
    Console.Write("Восскресение");
else Console.Write("Введен не верный номер дня недели");    

