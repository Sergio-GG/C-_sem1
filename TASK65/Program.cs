// Задайте значений M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от
// M до N  

Console.WriteLine("Введите число N: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int number2 = int.Parse(Console.ReadLine());
PrintNumber(number1,number2);


void PrintNumber(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num2} ");
        PrintNumber(num1, num2 - 1);
    }
   
    
    else if (num1 > num2)
    {
        Console.Write($"{num2} ");
        PrintNumber(num1, num2 + 1);     
    }
    else Console.Write($"{num2}");
}