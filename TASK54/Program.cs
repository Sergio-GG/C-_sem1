// Задайте двумерный массивю
// Напишите программу, которая упорядочит элементы
// КАЖДОЙ СТРОКИ по убыванию.


int[,] CreateNewRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}");
            else Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[] MatrixToArray(int[,] matr)
{
    int[] array = new int[matr.Length];
    int k = 0;
    while (k < matr.Length)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                array[k] = matr[i, j];
                k++;
            }
        }
    }
    return array;
}

void PrintArray(int[] arr, int[,] matr)
{
    int columns = matr.GetLength(1);
    int index = 0;
    while (index < arr.Length)
    { 
        Console.Write("[");
        for (int i = index; i < index + columns; i++)
        {
            
            if (i < index + columns -1)
            {
                Console.Write($"{arr[i]}, ");
            }
            if (i == (index + columns) - 1) 
            {
                Console.Write(arr[i]);
            }   
        }
        Console.WriteLine("]");
        index += columns;
    }
}

void SortedRowsArray(int[] arr, int[,] matr)
{
    int columns = matr.GetLength(1);
    int tempMin = 0;
    int index = 0;
    while (index < arr.Length)
    {
        for (int i = index; i < index + columns; i++)
        {        
            for (int j = i + 1; j < index + columns; j++)
            {
                if (arr[i] < arr[j])
                {
                    tempMin = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempMin;                   
                }
            }
        }
        index = index + columns;
    }
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Исследуемая матрица:");
int[,] matrix = CreateNewRandomMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = MatrixToArray(matrix);
Console.WriteLine("Неотсортированные строки двумерного массива:");
PrintArray(array, matrix);
SortedRowsArray(array, matrix);
Console.WriteLine();

Console.WriteLine("Отсортированные строки двумерного массива:");
PrintArray(array, matrix);