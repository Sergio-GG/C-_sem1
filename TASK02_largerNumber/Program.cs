
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) 
{
    Console.WriteLine($"max = {numberA}, min = {numberB}");
}
if (numberA < numberB) 
{
    Console.WriteLine($"max = {numberB}, min = {numberA}");
}
if (numberA == numberB) 
{
    Console.WriteLine("Числа равны");
}