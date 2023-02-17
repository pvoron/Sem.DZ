// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число а");
string userAnswerA = Console.ReadLine();
int userNumberA = Convert.ToInt32(userAnswerA);

Console.WriteLine("Введите число b");
string userAnswerB = Console.ReadLine();
int userNumberB = Convert.ToInt32(userAnswerB);

if(userNumberA > userNumberB)
{
    Console.WriteLine("max = " + userNumberA);
    Console.Write("min = " + userNumberB);
}
else
{
    Console.WriteLine("max = " + userNumberB);
    Console.Write("min = " + userNumberA);
}
