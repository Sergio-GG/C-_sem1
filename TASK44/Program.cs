// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] CreateArrayRndInt (int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

int[] Fibonacci (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < 2)
        {
            arr[i] = i;
        }
        if (i > 1)
        {
            arr[i] = arr[i-1] + arr[i-2];
        }
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


Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size);
Fibonacci(array);
PrintArray(array);