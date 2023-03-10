// Задайте двумерный массив
// Напишите программу, которая будет находить
// СТРОКУ с наименьшей суммой элементов

int[,] CreateRndMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(0,10);
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
            if ( j < matr.GetLength(1) - 1) Console.Write($"{matr[i,j], 3}");
            else Console.Write($"{matr[i,j], 3}");
        }
        Console.WriteLine("|");
    }
}


int RowWithMinSum(int[,] matr)
{
    int sum = 0;
    int minimalIndex = 0;
    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i,j];
            array[i] = sum;
        }
        sum = 0;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minimalIndex])
        {
            minimalIndex = i;
        } 
    }
    return minimalIndex + 1;
}


int[] ArrayOfSumOfRows(int[,] matr)
{
    int sum = 0;
    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i,j];
            array[i] = sum;
        
        }
        sum = 0;
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(" ", arr));
    Console.WriteLine("]");
}

int MinSumOfElements(int[] arr)
{
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minIndex])
        {
            minIndex = i;
        }
    }
    return arr[minIndex];
}


int[,] matrix = CreateRndMatrix(5,4);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Суммы строк в виде одномерного массива: ");
int[] array = ArrayOfSumOfRows(matrix);
PrintArray(array);
int minSum = MinSumOfElements(array);
Console.WriteLine();
System.Console.WriteLine($"Минимальная сумма строк равна {minSum}");
Console.WriteLine();
int rowMinSum = RowWithMinSum(matrix);
System.Console.WriteLine($"Строка с наименьшей суммой элементов ---> {rowMinSum}");