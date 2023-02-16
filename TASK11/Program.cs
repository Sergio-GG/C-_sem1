// Программа, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа
int number = Convert.ToInt32(new Random().Next(100, 1000));
Console.WriteLine(number);
int newNumber = Strip(number);
Console.WriteLine($"Новое число --> {newNumber}");

// Method

int Strip (int num)
{
    int firstNum = num / 100;
    int secondNum = num % 10;
    return firstNum * 10 + secondNum;
}


