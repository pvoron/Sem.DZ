// Задача 57: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

int ReadNumser(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)           // matrix.GetLength(0) - кол-во строк матрицы
    {
        for (int j = 0; j < matrix.GetLength(1); j++)        // matrix.GetLength(1) - кол-во столбцов матрицы
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)                              // метод для вывода матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)           // matrix.GetLength(0) - кол-во строк матрицы
    {
        for (int j = 0; j < matrix.GetLength(1); j++)        // matrix.GetLength(1) - кол-во столбцов матрицы
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ArrayWithOrderedValues(int[,] matrix)                                //метод для сортировки строк матрицы по возрастанию
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int value = 0; value < matrix.GetLength(1) - 1; value++)
            {
                if (matrix[i, value] > matrix[i, value + 1])
                {
                    int temp = 0;
                    temp = matrix[i, value];
                    matrix[i, value] = matrix[i, value + 1];
                    matrix[i, value + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int m = ReadNumser("Введите количество строк");
int n = ReadNumser("Введите количество столбцов");
int leftBorder = ReadNumser("Введите левую границу");
int rightBorder = ReadNumser("Введите правую границу");
int[,] myMatrix = GetRandomMatrix(m, n, leftBorder, rightBorder);
PrintMatrix(myMatrix);
Console.WriteLine("______________________________________");
int[,] myNewMatrix = ArrayWithOrderedValues(myMatrix);
PrintMatrix(myNewMatrix);
