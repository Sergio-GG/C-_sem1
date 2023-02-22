
Console.WriteLine("Введите длину массива");
int arrLen = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLen];
int[] newArray = ArrRand(array);
PrintArr(newArray);

// Method 1

int[] ArrRand(int[] arr)
{
    Random num = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num.Next(1, 101);
    }
    return arr;
}
 
 
// Method 2

void PrintArr(int[] arr)
{
    Console.WriteLine($"Массив из {arr.Length} элементов:");
    Console.Write("[");
    Console.Write(string.Join(", ", arr));
    Console.Write("]");
}