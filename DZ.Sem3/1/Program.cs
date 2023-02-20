// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int a = number % 10;
int b = (number / 10) % 10;
int c = (number / 1000) % 10;
int d = (number / 10000) % 10;

if (number >= 10000 && number <= 99999)
{
    if (a == d && b == c)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введите корректное число");
}

