// программа возващает произведение всех чисел от 1 до N


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = Counter (number);
Console.WriteLine($"Произведение равно {result}");
// Method

int Counter (int num)
{
    int multiply = 1;
    for (int i = 1; i <= num; i++)
    {
        multiply = multiply * i;
    }
    return multiply;
}


