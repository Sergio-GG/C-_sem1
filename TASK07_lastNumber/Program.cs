
Console.WriteLine("Введите техзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int result = number % 10;
    Console.WriteLine("Последняя цифра числа --> " + result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}