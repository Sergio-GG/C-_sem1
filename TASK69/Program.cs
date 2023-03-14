// Программа принимает на вход два числа - A и B
// и возводит число А в степень В с помощью рекурсии

Console.WriteLine("Введите число A: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int number2 = int.Parse(Console.ReadLine());
int res = PowNumbers(number1,number2);
Console.WriteLine($"Результат равен {res}");

int PowNumbers(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return num1 * PowNumbers(num1, num2 - 1);
}