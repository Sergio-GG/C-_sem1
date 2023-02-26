// Программа принимает массив из 12 чисел
// Заполненный числами из промежутка [-9, 9]
// и находит сумму положительных и отрицательных чисел

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
    return new int[]{sumNegative, sumPositive};
}

int [] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных чисел = {sumPositiveNegativeElem[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumPositiveNegativeElem[0]}");