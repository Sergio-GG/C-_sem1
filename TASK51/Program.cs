// Задать массив.Найти сумму элементов, 
// находящихся на главной диагонали.

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

int SumDiagonalElemMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
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

int[,] matrix = CreateMatrixRndInt(5,5);
PrintMatrix(matrix);
int result = SumDiagonalElemMatrix(matrix);
Console.WriteLine($"Сумма элементов равна {result}");