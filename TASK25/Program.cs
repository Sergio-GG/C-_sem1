// Программа принимает на вход два числа A и B
// и возводит число A в натуральную степень B


Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB > 0)
{
    int result = Exponent(numberA, numberB);
    Console.WriteLine($"{numberA} в степени {numberB} равно : {result}");
}
else Console.WriteLine($"Введите натуральное число B");

// Method

int Exponent(int numA, int numB)
{   
    int raiseToPow = 1;
    for (int i = 0; i < numB; i++)
    {
        checked
        {
            raiseToPow = raiseToPow * numA;
        }
    }
    return raiseToPow;
}
