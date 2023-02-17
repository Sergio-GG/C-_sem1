// Программа выводит вторую цифру 
// трехзначного числа


Console.WriteLine("Введите техзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int res = ThreeNum (number);
    Console.WriteLine("Вторая цифра числа --> " + res);
}
else
{
    Console.WriteLine("Введите трехзначное число");
}

// Method

int ThreeNum(int num)
{
    int firstStep = number / 10;
    int secondStep = firstStep % 10;
    return secondStep;
}