// программа принимает число на вход
// и выводид количество цифр в нем

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = Counter (number);
Console.WriteLine($"Количество цифр в числе {result}")
// Method

int Counter (int num)
{
    int counter = 0;
    while (num > 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}

