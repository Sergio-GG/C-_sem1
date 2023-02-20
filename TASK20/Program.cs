// Программа получает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int By = Convert.ToInt32(Console.ReadLine());

double result = Distance (Ax, Ay, Bx, By);
Console.WriteLine($"Расстояние между точками равно {result}");


// Method

double Distance (int p1, int p2, int  p3, int p4)
{
    double res = Math.Sqrt(Math.Pow((p3 - p1), 2) + Math.Pow((p4 -p2), 2));
    double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
    return resRound;
}