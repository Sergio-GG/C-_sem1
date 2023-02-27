// Создать одномерный массив
// Найти сумму элементов стоящих на нечетных позициях

// Method 1
int[] CreateRndArray(int size)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(0, 10);
    }
    return arr;
}


// Method 2
void PrintArray(int[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(", ", arr));
    Console.WriteLine("]");
}

// Method 3 (определяем сумму элементов на нечетных позициях)
int SumOfOdds (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}


Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRndArray(size);
int result = SumOfOdds(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях равна {result}");
