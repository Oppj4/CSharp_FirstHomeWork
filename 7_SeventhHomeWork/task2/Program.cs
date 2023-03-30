// Задача 2. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


int[,] CreateRndIntMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

string FindElementIndex(int[,] matr, int pos1, int pos2)
{

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i == pos1 & j == pos2) return $"{matr[i, j]}";
        }
    }
    return $"{pos1}, {pos2} -> такого элемента нет.";
}


void printMartix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4},");
            else Console.Write($"{matr[i, j], 4}");
        }    
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateRndIntMatrix(3, 4, 1, 9);
printMartix(matrix);

Console.Write("Введите первую позицию элемента: ");
int position1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую позицию элемента: ");
int position2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindElementIndex(matrix, position1, position2));