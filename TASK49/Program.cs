// Задать массив.Найти элементы, у которых все индексы четные и 
// заменить эти элементы на их квадраты

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

int[,] ReplacedMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix [i, j] * 2;
            }
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

int[,] matrix1 = CreateMatrixRndInt(4,4);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] replacedMatrix = ReplacedMatrix(matrix1);
PrintMatrix(replacedMatrix);