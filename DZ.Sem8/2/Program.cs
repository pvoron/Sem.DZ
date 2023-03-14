// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}

int m = ReadNumser("Введите количество строк");
int n = ReadNumser("Введите количество столбцов");
int leftBorder = ReadNumser("Введите левую границу");
int rightBorder = ReadNumser("Введите правую границу");
int[,] myMatrix = GetRandomMatrix(m, n, leftBorder, rightBorder);
PrintMatrix(myMatrix);

int minSumLine = 0;
int sumLine = SumLineElements(myMatrix, 0);
for (int i = 1; i < myMatrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(myMatrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");