﻿ // Задать двумерный массив размером m * n,
 // каждый элемент которого находится 
 // по формулезаполненный Amn = m+n


int[,] CreateMatrixRndInt (int rows, int colums)
{
    int[,] matrix  = new int[rows, colums];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }
       
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3}, ");
            else Console.Write($"{matrix[i,j], 3}");
        
        }    
        Console.WriteLine("]");
    }
}

int[,] array2d = CreateMatrixRndInt(3,4);
PrintMatrix(array2d);
