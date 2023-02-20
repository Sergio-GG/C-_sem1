// Программа принимает на вход число N
// и выдает таблицу квадартов числел
// от 1 до N


Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());

ProgN(numberN);


// Method

void ProgN (int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i,5}    {Math.Pow(i, 2),5}");
    }
}
