// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

int DifOfMaxAndMin(int[] array)                                          // Метод, возвращающий разницу max и min чисел массива
{
    int max = array[0];
    int min = array[0];
       for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    
    int dif = max - min;
    return dif;
}


int lengthOfArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу массива случайного диапазона");
int rightBorder = ReadNumber("Задайте правую границу массива случайного диапазона");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", myArray)}]");                                   // Вывод массива

int dif = DifOfMaxAndMin(myArray);
Console.WriteLine($"Разница между max и min - {dif}");