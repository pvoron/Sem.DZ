// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());


int daysOfMonth = 31;
int dateOfFirstMondey = 1;
int dateOfFirstSaturday = dateOfFirstMondey + 5;
int dateOfFirstSunday = dateOfFirstMondey + 6;

while (number <= daysOfMonth)
{
    dateOfFirstSaturday += 7;
    dateOfFirstSunday += 7;
}
if(number % dateOfFirstSaturday == 0)
{
    Console.WriteLine(number + "- выходной день");
}
else if (number % dateOfFirstSunday == 0)
{
    Console.WriteLine(number + "- выходной день");
}
else
{
    Console.WriteLine(number + "- будний день");
}

//Console.WriteLine(number);

//if (number <= daysOfMonth)
//{
    //if (number == dateOfFirstMondey += 6 || number == dateOfFirstMondey += 7)
   // {
   //     Console.WriteLine(number + "- выходной день");
   // }
   // else
//{
   //      Console.WriteLine(number + "- будний день");
  //  }
//}
//else
//{
  //  Console.WriteLine("число введено некорректно");
//}