Console.WriteLine("Введите целое число");
int numberN = Convert.ToInt32(Console.ReadLine());
CubeNumber(numberN);

// Method

void CubeNumber(int num)
{
    int index = 1;
    while (index <= num)
    {
        double cubes = Math.Pow(index, 3);
        Console.WriteLine($"{index, 5}     {cubes,5}");
        index++;
    }
}