/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double DistanceAB (int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb; 
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);//вычисление длины отрезка
    return distAB;
}

// ввод координат точки А
Console.WriteLine ("input x for point A");
int xACoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input y for point A");
int yACoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input z for point A");
int zACoord = Convert.ToInt32(Console.ReadLine());

// ввод координат точки В
Console.WriteLine ("input x for point B");
int xBCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input y for point B");
int yBCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input z for point B");
int zBCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"distance = {DistanceAB(xACoord, yACoord, zACoord, xBCoord, yBCoord, zBCoord):f2}");
