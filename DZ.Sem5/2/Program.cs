// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

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

int NumberOfOdd(int[] array)                                          // Метод, возвращающий сумму чисел, стоящих на нечетных позициях
{
    int sumOfOdd = 0;
       for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sumOfOdd += array[i]; 
        }
    }
    return sumOfOdd;
}


int lengthOfArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу массива случайного диапазона");
int rightBorder = ReadNumber("Задайте правую границу массива случайного диапазона");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", myArray)}]");                                   // Вывод массива

int Sum = NumberOfOdd(myArray);
Console.WriteLine($"Количество четных элементов - {Sum}");