﻿Console.WriteLine("Задайте координату по оси оx для первой точки");
Console.WriteLine("Задайте координату по оси оy для первой точки");
Console.WriteLine("Задайте координату по оси оz для первой точки");
Console.WriteLine("Задайте координату по оси оx для второй точки");
Console.WriteLine("Задайте координату по оси оy для второй точки");
Console.WriteLine("Задайте координату по оси оz для второй точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2)) + Math.Pow((y2 - y1), 2)) + Math.Pow((z2 - z1), 2);
Console.WriteLine("Расстояние между двумя точками в 3d пространстве равно " + d);
