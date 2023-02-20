Console.WriteLine("Введите координаты");
Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
string result = quarter > 0
                ? $"Указанные координаты соответствуют {quarter} четверти"
                : "Введены некооректные координаты";
Console.WriteLine(result);

//Method 

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    else return 0;
}