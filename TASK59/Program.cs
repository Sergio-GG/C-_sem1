// Задать двумерный массив из целых чисел
// Написать программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива

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

int[] IndexOfMinElement(int[,] matrix)
{
    int minEl = matrix[0,0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] <= matrix[row, column])
            {
                row = i;
                column = j;
            }
        }
    }
    return new int[]{row, column};
}


int[,] DeletedMatrixRowColomn(int[,] matrix, int[] array)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == array[0]) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == array[1]) n++;
            newMatrix[i,j] = matrix[m,n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
} 


void PrintArray(int[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(", ", arr));
    Console.WriteLine("]");
}


int[,] matrix = CreateMatrixRndInt(5,4);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = IndexOfMinElement(matrix);
PrintArray(array);
Console.WriteLine();
int[,] newMatrix = DeletedMatrixRowColomn(matrix, array);
PrintMatrix(newMatrix);
