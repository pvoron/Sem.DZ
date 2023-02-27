// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int numberOfUser)
{
    int sum = 0;
    while(numberOfUser > 0)
    {
        sum = sum + numberOfUser % 10;
        numberOfUser /= 10;
    }
    return sum;
}

int number = ReadNumber("Введите число А");
int result = SumOfDigits(number);
Console.WriteLine(result);