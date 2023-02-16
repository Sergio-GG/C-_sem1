// Программа, которая
// 1. генерирует случайное число от 10 до 99
// 2. выводит на экран большую цифру из этого числа

int number = Convert.ToInt32(new Random().Next(10, 100));
Console.WriteLine(number);
int maxnum = MaxNumber(number);
Console.WriteLine($"Наибольшее число --> {maxnum}");

// Method
int MaxNumber(int num)
{
    int firstNumber = num / 10;
    int secondNumber = number % 10;
    int res = firstNumber > secondNumber ? firstNumber : secondNumber;
    return res;
}