// Программа находит расстояние между двумя точками
// в 3D пространстве.


Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double result = Distance(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine($"Расстояние между точками равно {result}");


// Method 

double Distance ( int x1,int y1, int z1, int x2, int y2, int z2)
{
    int Xdiff = x2 - x1;
    int Ydiff = y2 - y1;
    int Zdiff = z2 - z1;
    double dist = Math.Sqrt(Math.Pow(Xdiff, 2) + Math.Pow(Ydiff, 2) + Math.Pow(Zdiff, 2));
    double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);
    return distRound;
}