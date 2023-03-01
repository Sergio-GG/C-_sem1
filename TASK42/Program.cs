// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int DecToBin (int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result = result + num % 2 * count;
        num = num / 2;
        count *= 10;
    }
    return result;
}
int decToBin = DecToBin(number);
System.Console.WriteLine($"{number} --> {decToBin}");
