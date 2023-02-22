// Программа принимает число 
// и выдает сумму цифр в числе


Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int res = Summa(numberA);
Console.WriteLine($"сумма цифр в числе {numberA} равна: {res}");

// Method

int Summa(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int numA = num % 10;
        sum = sum + numA;
        num = num / 10;
    }
    return sum;
}
