// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a");
string userAnswerA = Console.ReadLine();
int NumberA = Convert.ToInt32(userAnswerA);

Console.WriteLine("Введите число b");
string userAnswerB = Console.ReadLine();
int NumberB = Convert.ToInt32(userAnswerB);

Console.WriteLine("Введите число c");
string userAnswerC = Console.ReadLine();
int NumberC = Convert.ToInt32(userAnswerC);

int max = NumberA;
if(NumberB > max)
{
    max = NumberB;
}
if(NumberC > max)
{
    max = NumberC;
}
Console.Write("max = ");
Console.WriteLine(max);
