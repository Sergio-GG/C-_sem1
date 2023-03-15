// Задайте занчение N. напишиет программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии


Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
PrintNumbers(numberN);

void PrintNumbers(int num)
{
    if (num == 0 ) return;
    else if (num > 1) Console.Write($"{num}, ");
    else System.Console.WriteLine(num);
    PrintNumbers(num - 1);
}