// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.

Console.WriteLine("Введите число N: ");
int number1 = int.Parse(Console.ReadLine());
int sum = SumNumbers(number1);
Console.WriteLine($"Сумма равна {sum}");


int SumNumbers(int num)
{
    if (num == 0) return num;
    else return num % 10 + SumNumbers(num / 10);
}