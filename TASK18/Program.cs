// Программа определяет диапазон значений координат
// исходя из введенной четверти.


Console.WriteLine("Введите номер четверти");
string number = Console.ReadLine();
string range = Range(number);
string result = range == "0"
                ? "Такой четверти не существует"
                : $"Диапазон значений данной четверти {range}";

Console.WriteLine(result);



// Method 

string Range(string num)
{
    if (num == "1") return "x > 0, y > 0";
    if (num == "2") return "x < 0, y > 0";
    if (num == "3") return "x < 0, y < 0";
    if (num == "4") return "x > 0, y < 0";
    return "0";
}
