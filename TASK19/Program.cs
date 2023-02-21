// Программа, определяющая является ли число
// палиндромом.


Console.WriteLine("Введите число");
int numPal = Convert.ToInt32(Console.ReadLine());
if (IsPalindrome(numPal)) Console.WriteLine("Является палиндромом");
else Console.WriteLine("Не является палиндромом");

// Method

bool IsPalindrome (int num)
{   
    string numStr = Convert.ToString(num); // определяем длину строки
    int len = numStr.Length;               // с помощью метода .Length

    double sum = 0;     // это накопитель суммы
    int charNumber = num; // переменная charNumber будет с каждым разом уменьшаться в 10 раз
    while (len > 0)
    {   
        int charNumber1 = charNumber % 10;   // charNumber1 - записывает последнюю цифру оставшегося числа
        double charNewNumber = charNumber1 * Math.Pow(10, len-1); // умножает эту цифру на 10 в степени (len - 1)
        sum = sum + charNewNumber;  //и переносит ее в левую сторону sum
        len = len - 1;
        charNumber = charNumber / 10; // укорачиваем число на одну цифру и записываем в переменную charNumber
    }
    return sum == num;
}   


