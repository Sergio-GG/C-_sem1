// Программа принимает два числа
// и проверяет, является ли ли одно из них квадратом другого


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (Square(numberA,numberB)) Console. WriteLine ("Да");
else Console. WriteLine ("Нет");



// Method

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
