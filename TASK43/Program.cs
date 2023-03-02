// Найти точку пересечения двух прямых,
// заданных уравнениями 
// y = k1 * x + b1
// y = k2 * x + b2

// Решение
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)



Console.WriteLine("Введите коэффициент k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = Convert.ToInt32(Console.ReadLine());

// Method

double[] Coordinates(double num1, double num2, double num3, double num4)
{
    double[] arr = new double[2];
    double x = (num4 - num3) / (num1 - num2);
    double y = num1 * x + num3;
    x = Math.Round(x,1,MidpointRounding.ToZero);
    y = Math.Round(y,1,MidpointRounding.ToZero);
   
    arr[0] = x;
    arr[1] = y;
    return arr;
}

void PrintArray(double[] arr)
{
    string array = string.Join(", ", arr);
    Console.Write($"Координаты точки пересечения прямых ({array})");
}

double[] cordinates = Coordinates(k1, k2, b1, b2);
PrintArray(cordinates);

