// Задайте массив , заполненный случайными трехзначными числами
// Определить количество четных чисел в массиве

// Method 1 (создание массива со случайными трехзначными числами)
int[] CreateArrayRndInt (int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

// Method 2 (вывод массива на экран)
void PrintArray (int[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(", ", arr));
    Console.WriteLine("]");
}


// Method 3 (проверка элементов на четность)
int IsEven (int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            counter++;
        }    
    }
    return counter;
}

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size);
int result = IsEven(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных элементов равно {result}");