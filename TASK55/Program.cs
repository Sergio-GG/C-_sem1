
int[,] CreateMatrixRndInt(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }

    }
    return matrix;
}


int[,] ReplaceToColumns(int[,] matrix)
{
    int[,] matr1 = new int[matrix.GetLength(0), matrix.GetLength(1)];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr1[i, j] = matrix[j, i];
        }
    }

    return matr1;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");

        }
        Console.WriteLine("]");
    }
}

int[,] array = CreateMatrixRndInt(4, 4);
PrintMatrix(array);
System.Console.WriteLine();
int[,] newarr = ReplaceToColumns(array);
PrintMatrix(newarr);






