// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


int ReadNumber(string messageToUser)                                   // Метод, возвращающий число
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[] positiveNumber(int n)                                               // Метод, возвращаюищй массив с n количеством элементов
{
    int[] array = new int[n];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber($"{i + 1}");
    }
    return array;
}

void printPositiveNumber(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int sumPositiveNumber(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
int number = ReadNumber("Введите количество элементов");
int[] myArray = positiveNumber(number);
printPositiveNumber(myArray);
int sum = sumPositiveNumber(myArray);
Console.WriteLine($"{sum} положительных значений в массиве: [{string.Join(", ", myArray)}]");
