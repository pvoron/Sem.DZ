// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string messageToUser)
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

int rows = ReadNumber("Введите количество строк");
int columns = ReadNumber("Введите количество столбцов");
int leftBorder = ReadNumber("Введите левую границу");
int rightBorder = ReadNumber("Введите правую границу");
int[,] myMatrix = GetRandomMatrix(rows, columns, leftBorder, rightBorder);
PrintMatrix(myMatrix);

for (int j = 0; j < myMatrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        sum += myMatrix[i, j];
    }
    Console.Write($" { sum / myMatrix.GetLength(0)} ");
}