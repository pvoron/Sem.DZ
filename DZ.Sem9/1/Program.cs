// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void StringOfNumbers(int n)
{
    if (n < 0) throw new Exception($"{n} - не натуральное число");
    if (n == 0) return;
    Console.Write($"{n} ");
    StringOfNumbers(n - 1);
}

int numberN = ReadNumber("Введите число");
StringOfNumbers(numberN);