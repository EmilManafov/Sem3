/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите x точки A: ");
int xa = int.Parse(Console.ReadLine()!);

Console.Write("Введите y точки A: ");
int ya = int.Parse(Console.ReadLine()!);

Console.Write("Введите z точки A: ");
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("");

Console.Write("Введите x точки B: ");
int xb = int.Parse(Console.ReadLine()!);

Console.Write("Введите y точки B: ");
int yb = int.Parse(Console.ReadLine()!);

Console.Write("Введите z точки B: ");
int zb = int.Parse(Console.ReadLine()!);


double s = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между A и B равно {s:f2}");