// создать частотный словарь элементов двумерного массива
// частотный словарь содержит информацию о том,
// сколько раз встречается элемент вводных данных.


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

void PrintArray(int[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(", ", arr));
    Console.WriteLine("]");
}


int[] ArrayOne(int[,] matr)
{
    int index = 0;
    int[] array = new int[matr.GetLength(0) * matr.GetLength(1)];
    while (index < matr.GetLength(0) * matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                array[index] = matr[i,j];
                index++;
            } 
        }
        
    }
    return array;    
}

void FreqNumber(int[] newArr)
{
    int count = 1;
    int findNum = newArr[0];
    for (int i = 1; i < newArr.Length; i++)
    {
        if (newArr[i] == findNum) count++;
        else
        {
            Console.WriteLine($"Число {findNum} встречается {count} раз");
            findNum = newArr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {findNum} встречается {count} раз");
}


int[,] matrixA = CreateMatrixRndInt(4,4);
PrintMatrix(matrixA);
int[] array = ArrayOne(matrixA);
Array.Sort(array);
FreqNumber(array);
PrintArray(array);

