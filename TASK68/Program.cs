// Вычисление функции Аккермана с помощью рекурсии.


Console.WriteLine("Введите число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > -1 && number2 > -1)
{
    int res = AkkermanFoo(number1,number2);
    Console.WriteLine($"Результат функции А({number1},{number2}) --> {res}");
}
else Console.WriteLine("Введите положительные числа");

int AkkermanFoo(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0)
    {
        return AkkermanFoo(numM - 1, 1);
    }
    else return AkkermanFoo(numM - 1, AkkermanFoo(numM, numN - 1));
}