// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Введите первое число");
int numberB = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Введите первое число");
int numberC = Convert.ToInt32(System.Console.ReadLine());



bool Triangle (int num1, int num2, int num3)
{
    if (num1 + num2 < num3 || num2 + num3 < num1 || num3 + num1 < num2) return true;
    else return false;
}

bool result = Triangle(numberA, numberB, numberC);

Console.WriteLine(result ? "Треугольник существует" : "Треугольник не существует");
