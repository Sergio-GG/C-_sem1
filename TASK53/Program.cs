// Задайте двумерный массив
// программа меняет первую и последнюю строку массива
int[,] CreateMatrixRndInt (int rows, int colums)
{
    int[,] matrix  = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(0, 10);
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


void Replace(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[firstRow,j];
        matrix[firstRow,j] = matrix[lastRow, j];
        matrix[lastRow, j] = temp;
    }
}


int[,] array = CreateMatrixRndInt(4,5);
PrintMatrix(array);
Replace(array);
Console.WriteLine();
PrintMatrix(array);