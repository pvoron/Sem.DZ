// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

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

int xPosition = ReadNumber("Введите число по X");
int yPosition = ReadNumber("Введите число по Y");

if (xPosition < 0 | xPosition > myMatrix.GetLength(0) - 1 | yPosition < 0 | yPosition > myMatrix.GetLength(1) - 1)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента: {myMatrix[xPosition, yPosition]}");
}
