// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] NewArray (int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size);
int[] newArray = NewArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);