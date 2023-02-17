Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == 0) Console.WriteLine("Введите любое число кроме нуля");

int last = numberA % numberB;
int newNumber = Multyplicity(numberA, numberB);
if (newNumber == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно. Остаток от деления -> {last}");


// Method

int Multyplicity(int num1, int num2)
{
    int res = num1 % num2;
    return res;
}