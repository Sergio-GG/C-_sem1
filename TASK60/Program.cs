// Создать трехмерный массив из неповторяющихся чисел 
// и вывести его построчно, добавляя индексы каждого элемента


int[,,] Create3DArray(int rows,int columns,int depths)
{
    int[,,] array3D = new int[rows, columns,depths];
    Random rand = new Random();
    int[] arrayForCheck = new int[array3D.Length+1];
    int index = 1;
    arrayForCheck[0] = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = rand.Next(10,100); 
                arrayForCheck[index] = array3D[i,j,k];
                if (arrayForCheck[index] == arrayForCheck[index-1])
                {
                    array3D[i, j, k] = rand.Next(10,100);    
                }
                index++;
            }
           
        }
        
    }
    return array3D;
}


void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k], 2}[{i},{j},{k}] ");
            }
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("Введите число строк массива ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число глубины массива");
int depths = Convert.ToInt32(Console.ReadLine());
int[,,] new3DArray = Create3DArray(rows,columns,depths);
Print3DArray(new3DArray);