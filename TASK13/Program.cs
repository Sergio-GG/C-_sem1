// Программа выводит третью цифру числа,
// если таковая имеется.


Console. WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 99)
{
    int res = Strip(numberA);
    Console.WriteLine(res);
}
else Console.WriteLine("Тертьей цифры нет");


// Method

int Strip (int num)
{
    while (num > 999)
    {
        num = num / 10;
    } 
    int number = num % 10;
    return number;
}
