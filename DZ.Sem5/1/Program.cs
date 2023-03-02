// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int ReadNumber(string messageToUser)                                   // Метод, возвращающий число
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetRandomArray(int length, int leftRange, int rightRange)        //Метод, возвращающий рандомный массив length длины, leftRange и rightRange границ
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange,rightRange + 1);
    }

    return array;
}

int NumberOfEven(int[] array)                                          // Метод, возвращающий количество четных элементов массива
{
    int sumOfEven = 0;
       for(int i = 0; i < array.Length; i++)
    {
        if(array [i] % 2 == 0)
        {
            sumOfEven += i / i; 
        }
    }
    return sumOfEven;
}


int lengthOfArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу массива случайного диапазона");
int rightBorder = ReadNumber("Задайте правую границу массива случайного диапазона");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", myArray)}]");                                   // Вывод массива

int Sum = NumberOfEven(myArray);
Console.WriteLine($"Количество четных элементов - {Sum}");