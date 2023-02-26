// Программа определяет количество двузначных числел
// в одномерном массиве из 123 случайных элементов




int[] CreateArrayRndInt (int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 1000);
    }
    return arr;
}

int CountNumbers(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            counter += 1;
        }
    }
    return counter;
}

void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
        
    }    
    Console.Write("]");
    
}


Console.WriteLine("Введите длину массива");
int sizeOfArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(sizeOfArr);
PrintArray(array);
Console.WriteLine();
int counts = CountNumbers(array);
Console.WriteLine($"Количество двузначных чисел равно {counts}");