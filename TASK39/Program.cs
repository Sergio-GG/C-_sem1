﻿// Разворот массива

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

void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1- i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrayRndInt(10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
