int[] CreateArray(int M, int min, int max)
{
    int[] arr = new int[M];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min,max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(", ", arr));
    Console.WriteLine("]");
}

int CountOfNaturals(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

Console.WriteLine("Введите длину массива");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int numberMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int numberMax = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(numberM, numberMin, numberMax);
PrintArray(array);
int result = CountOfNaturals(array);
Console.WriteLine($"Количество натуральных чисел равно {result}");
