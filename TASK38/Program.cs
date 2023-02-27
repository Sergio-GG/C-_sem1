// Задать массив вещественных чисел
// Определить разницу между максимальным и минимальным элементами массива

double[] CreateArrDouble(int size, int range)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.NextDouble() * range;
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArrayDouble( double[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(", ", arr));
    Console.WriteLine("]");
}

double[] SortedArray (double[] arr)
{
    double temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i +1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

double Difference(double[] arr)
{
    int size = arr.Length;
    double res = arr[size - 1] - arr[0];
    return res;
}

System.Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите диапазон значений");
int range = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrDouble(size, range);
PrintArrayDouble(array);

double[] sortedArray = SortedArray(array);
PrintArrayDouble(sortedArray);

double result = Difference(sortedArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами равна {result}");