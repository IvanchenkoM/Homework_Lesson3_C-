// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D.
int aX = ReadInt("Enter the coordinate X of point A: ");
int aY = ReadInt("Enter the coordinate Y of point A: ");
int aZ = ReadInt("Enter the coordinate Z of point A: ");
int bX = ReadInt("Enter the coordinate X of point B: ");
int bY = ReadInt("Enter the coordinate Y of point B: ");
int bZ = ReadInt("Enter the coordinate Z of point B: ");

//distance = Sqr ((x2-x1)^2+(y2-y1)^2+(z2-z1)^2)

double distance = Math.Sqrt(Math.Pow((bX-aX),2)+Math.Pow((bY-aY),2)+Math.Pow((bZ-aZ),2));
Console.Write(distance);

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}