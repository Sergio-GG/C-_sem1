// Является ли число кратным 7 и 23


Console.WriteLine("Введите число");
int numberX = Convert.ToInt32(Console.ReadLine());


if (Ismulty(numberX)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

// Method

bool Ismulty (int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

