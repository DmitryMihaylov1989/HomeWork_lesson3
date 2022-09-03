//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



// Напишите программу которая на вход принимает координаты 
// двух точек и выдает расстояние между ними в 3д пространстве

Console.WriteLine("Введите координаты первой точки");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Pifagor(int xc1, int yc1, int zc1 ,int xc2, int yc2, int zc2)
{
    return Math.Sqrt((xc2-xc1)*(xc2-xc1) + (yc2-yc1)*(yc2-yc1) + (zc2-zc1)*(zc2-zc1));    
}
double result = Pifagor(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"длина между точками в пространстве 3d это " +Math.Round(result, 2));

