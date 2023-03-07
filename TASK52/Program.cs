// Найти среднее арифметическое в каждом столбце двумерного массива


int[,] CreateRndMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(-10, 10);
        }
    }
    return matrix;
}

double[] Average(int[,] matr)
{
    double[] array = new double[matr.GetLength(1)]; // массив для записи значений в него
    double sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++) // итерация столбцов
    {
        for (int i = 0; i < matr.GetLength(0); i++) // итерация строк
        {
            sum += matr[i,j];
        }
        array[j] = sum / matr.GetLength(0); // стреднее арифметическое столбца
        sum = 0;
    }
    return array;
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

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
        
    }    
    Console.Write("]");
    
}





int[,] matrix = CreateRndMatrix(4,3);
PrintMatrix(matrix);
double[] array = Average(matrix);
System.Console.Write($"Среднее арифметическое элементов каждого столбца ---> ");
PrintArray(array);


