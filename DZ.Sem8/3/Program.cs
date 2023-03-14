// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

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

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int m = ReadNumser("Введите число строк 1-й матрицы:");
int n = ReadNumser("Введите число столбцов 1-й матрицы (и строк 2-й):");
int p = ReadNumser("Введите число столбцов 2-й матрицы:");
int leftBorder = ReadNumser("Введите левую границу");
int rightBorder = ReadNumser("Введите правую границу");

int[,] firstMatrix = GetRandomMatrix(m, n, leftBorder, rightBorder);
PrintMatrix(firstMatrix);
Console.WriteLine("____________________________________");

int[,] secondMatrix = GetRandomMatrix(n, p, leftBorder, rightBorder);
PrintMatrix(secondMatrix);
Console.WriteLine("____________________________________");

int[,] resultMatrix = new int [m, p];
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);