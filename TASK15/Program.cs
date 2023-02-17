// Программа принимает число, соответсвующее дню недели
// и и определяет, является ли день выходным.



Console. WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 0 && numberA < 8)
{
    if (Day(numberA)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Введите число от 1 до 7 включительно");



// Method
bool Day(int num)
{
    return num > 5;
}