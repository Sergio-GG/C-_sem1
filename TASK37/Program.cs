// Найти произведение пар в одномерном массиве
// Парой считается перове и последнее, второе и предпоследнее и т.д.


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

int[] Multiply (int[] arr)
{
    int allSize = arr.Length;
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;

    int[] res = new int[size];
    for (int i = 0; i < allSize; i++)
    {
        res[i] = arr[i] * arr[allSize - 1];
        allSize--;
        if (i == allSize)
        {
            res[i] = arr[i];
        }
    }
    return res;
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

int[] array = CreateArrayRndInt(7);
PrintArray(array);
Console.WriteLine();
int[] multy = Multiply(array);
PrintArray(multy);

