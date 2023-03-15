// Задайте значения M и N. Напишите программу, которая найдет сумму натуральныч элементов
// в промежуте от M до N. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int number2 = int.Parse(Console.ReadLine());
int sum = SumNumbers(number1,number2);
Console.WriteLine(sum);

int SumNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        if (num1 == num2) return num1;
        else return num1 + SumNumbers(num1 -1, num2);
    }
    else
    {
        if (num2 == num1) return num2;
        else return num2 + SumNumbers(num1, num2-1);
    }
}    

