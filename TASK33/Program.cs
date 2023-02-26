// Программа определяет , присутствует ли заданное число в массиве

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


bool IsInside (int[] arr, int num)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            counter += 1;
        } 
    }
    return counter > 0;
}

int[] array = CreateArrayRndInt (12, -9, 10);
System.Console.WriteLine("Веедите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
Console.WriteLine();
if (IsInside(array, number)) Console.WriteLine($"Такое число есть в массиве");
else Console.WriteLine("Такого числа нет в массиве");

