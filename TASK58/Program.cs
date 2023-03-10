// Задайте две матрицы
// Найти произведение двух матриц

int[,] CreateIntMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
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
            if (j < matr.GetLength(1) -1) Console.Write($"{matr[i,j], 4}");
            else Console.Write($"{matr[i,j], 4}  ");
        }
        Console.WriteLine("|");
    }
}

bool IsColumnsAndRowsEqual(int[,] matr1, int[,] matr2)
{
    return matr1.GetLength(1) == matr2.GetLength(0);
}

int[,] MultyMatrix(int[,] matr1, int[,] matr2)
{
    int[,] newMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    int index = 0;
    int sum = 0;
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            while (index < matr1.GetLength(1))
            {
                sum += matr1[i, index] * matr2[index, j];
                index++;   
            }
            newMatrix[i,j] = sum;
            sum = 0;
            index = 0;
        }     
    }
    return newMatrix; 
}



Console.WriteLine("Введите число строк первой матрицы ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк второй матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrixFirst = CreateIntMatrix(rows1,columns1);
int[,] matrixSecond = CreateIntMatrix(rows2,columns2);

PrintMatrix(matrixFirst);
Console.WriteLine();
Console.WriteLine();
PrintMatrix(matrixSecond);
bool isEqual = IsColumnsAndRowsEqual(matrixFirst, matrixSecond);
Console.WriteLine();
if (isEqual)
{
    int[,] multyMatrix = MultyMatrix(matrixFirst,matrixSecond);
    PrintMatrix(multyMatrix);
}
else Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы");



