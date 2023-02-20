// Задача 21/ Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double xA = ReadNumber("Введите кординату точуи по xA");
double yA = ReadNumber("Введите кординату точуи по yA");
double zA = ReadNumber("Введите кординату точуи по zA");
double xB = ReadNumber("Введите кординату точуи по xB");
double yB = ReadNumber("Введите кординату точуи по yB");
double zB = ReadNumber("Введите кординату точуи по zB");

double res = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)  + Math.Pow(zB - zA, 2));

Console.WriteLine($"{res:f2}");