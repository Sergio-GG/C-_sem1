// программа принимает на вход число (а)
// и выдает сумму чисел от1 до А

Console. WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(number);
Console.WriteLine(result);

//Method

int SumNumbers (int num)
{   
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
