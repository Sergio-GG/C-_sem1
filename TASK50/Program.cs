// Программа на вход принимает позицию элемента в двумерном массиве
// и возвращает элемент, если он есть


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

void PrintResult(int[,] matr, int argI, int argJ)
{
    if (argI < matr.GetLength(0) && argJ < matr.GetLength(1))
    {
        Console.WriteLine($"Элемент с индексами [{argI},{argJ}] ---> {matr[argI,argJ]}");
    }
    else Console.WriteLine("Ошибка ввода, введите значение из допустимого диапазона");
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


Console.WriteLine("Введите индекс i");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс j");
int indexJ = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRndMatrix(5,4);
PrintMatrix(matrix);
PrintResult(matrix, indexI, indexJ);