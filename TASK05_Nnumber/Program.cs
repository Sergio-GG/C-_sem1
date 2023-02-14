
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int counter = -number;
while (counter <= number)
{
    Console.Write(counter + " ");
    counter++;
}
