Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
{
    int counter = 1;
    while (counter <= number)
    {
        if (counter % 2 == 0)
        {
            Console.Write(counter + " ");
        }
        counter++;
    }
}
else Console.WriteLine("Введите число больше единицы");