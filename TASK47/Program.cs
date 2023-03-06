// Задать двумерный массив размером m * n , 
// заполненный случайными вещественными числами


double[,] CreateRandDoubleMatrix(int rows, int columns,int min, int max)
{
    double[,] matrix  = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i,j], 4} ");
            else Console.Write($"{matr[i,j], 4}");
        
        }    
        Console.WriteLine("|");
    }
}


Console.WriteLine("Введите минимум значений элементов");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимум значений элементов");
int max = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateRandDoubleMatrix(5,4,min,max);
PrintDoubleMatrix(matrix);