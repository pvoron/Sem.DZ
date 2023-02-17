// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());

int daysOfMonth = 31;
int dateOfFirstMondey = 1;
int dateOfFirstTuesday= dateOfFirstMondey + 1;
int dateOfFirstWednesday = dateOfFirstMondey + 2;
int dateOfFirstThursday = dateOfFirstMondey + 3;
int dateOfFirstFriday = dateOfFirstMondey + 4;
int dateOfFirstSaturday = dateOfFirstMondey + 5;
int dateOfFirstSunday = dateOfFirstMondey + 6;

for (int i = dateOfFirstMondey; i <= daysOfMonth; i = i + 7)
{
    if (number == i)
    {
        Console.WriteLine(number + "- будний день");
    }
}
for (int i = dateOfFirstTuesday; i <= daysOfMonth; i = i + 7)
{
    if (number == i)
    {
        Console.WriteLine(number + "- будний день");
    }
}
for (int i = dateOfFirstWednesday; i <= daysOfMonth; i = i + 7)
{
    if (number == i)
    {
        Console.WriteLine(number + "- будний день");
    }
}
for (int i = dateOfFirstThursday; i <= daysOfMonth; i = i + 7)
{
    if (number == i)
    {
        Console.WriteLine(number + "- будний день");
    }
}
for (int i = dateOfFirstFriday; i <= daysOfMonth; i = i + 7)
{
    if (number == i)
    {
        Console.WriteLine(number + "- будний день");
    }
}
for (int i = dateOfFirstSaturday; i <= daysOfMonth; i = i + 7)
{
    if (number == i)
    {
        Console.WriteLine(number + "- выходной день");
    }
}
for (int i = dateOfFirstSunday; i <= daysOfMonth; i = i + 7)
{
    if (number == i)
    {
        Console.WriteLine(number + "- выходной день");
    }
}