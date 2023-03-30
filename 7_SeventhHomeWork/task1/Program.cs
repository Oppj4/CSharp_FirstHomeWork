// Задача 1. Задайте двумерный массив размером m x n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateRndDoubMatrix(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = min + Math.Round(rnd.NextDouble() * (max - min), 1);
        }
    }
    return matrix;
}

void printMartix(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4} ");
            else Console.Write($"{matr[i, j], 4}");
        }    
        Console.WriteLine("]");
    }
}

double[,] matrix = CreateRndDoubMatrix(3, 4, 1, 20);
printMartix(matrix);