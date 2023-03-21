Console.WriteLine("Введите кординаты первой точки");
Console.WriteLine("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int wA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты второй точки");
Console.WriteLine("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int wB = Convert.ToInt32(Console.ReadLine());

double result = Math.Round (Distance(xA, yA, wA, xB, yB, wB), 2, MidpointRounding.ToZero);

Console.WriteLine($"Это пространство числа {result}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)   
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2 ) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}