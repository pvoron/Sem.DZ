﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. (номер цифры считается от левого края)

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    while (number >= 1000)
    {
        number /= 10;
    }
    int lastDigit = number % 10;
    Console.WriteLine(lastDigit);
}

else if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
